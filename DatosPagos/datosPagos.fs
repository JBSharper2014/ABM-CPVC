namespace DatosPagos

open System
open System.Data
open System.Windows.Forms
open Templates




module UpdateCommands =
    open System.Linq.Expressions
    open System.Security.Cryptography
   
    // Modifica varios campos
    let updateMany (option : int, parameters :  Object[]) =
        match option with 
      

         | _ ->              //Patron no encontrado
            MessageBox.Show("El numero enviado como parametro no coincide con ningun patron de modificacion")
            |> ignore

    // modifica un solo campo
    let updateOne (option : int, cod : int, parameter : Object) =
        match option with
       
        | 2 ->            // Modifica una orden de pago a debitada
            let orden = cod
            let str = String.Format("UPDATE [2_orden_pago]
            SET debitada = 1
            WHERE cod_orden_pago = {0}",orden)
            ExecuteCommands.execute str

        | 3 ->            // Resta el saldo de la factura a la cuenta de la empresa especificada
            let cuentaEmpresa = cod
            let importe = parameter :?> int
            let str = String.Format("UPDATE [2_cuenta_bancaria_empresa]
            SET saldo = saldo - {0}
            WHERE cod_cuenta_bancaria = {1}",importe,cuentaEmpresa)
            ExecuteCommands.execute str
        | 4 ->            // Resta el saldo de la factura al haber de la cuenta corriente con el proveedor.
            let cuentaProveedor = cod
            let importe = parameter :?> int
            let str = String.Format("UPDATE [1_cuenta_corriente_proveedor]
            SET haber = haber - {0}
            WHERE (cod_proveedor = {1})",importe,cuentaProveedor)
            ExecuteCommands.execute str
        | 5 ->            // Asocia una cuenta bancaria de la empresa con una orden de pago
            let orden = cod
            let cuenta = parameter :?> int
            let str = String.Format("UPDATE [2_orden_pago]
            SET
            cod_cuenta_bancaria = {0},
            aceptada_pago = 1
            WHERE cod_orden_pago = {1}", cuenta, orden)
            ExecuteCommands.execute str
        | _ ->              //Patron no encontrado
            MessageBox.Show("El numero enviado como parametro no coincide con ningun patron de modificacion")
            |> ignore
            
            
module InsertsCommands =
    open System.Data.SqlTypes
  

    let rec insertInto (option : int, parameters : Object[]) =
        match option with 
        
        |20 ->             // Inserta una orden de pago
            let codFactura = parameters.[0] :?> int
            let codProveedor = parameters.[1] :?> int
            let codBancoProveedor = parameters.[2] :?> int
            let observaciones = parameters.[3] :?> string
            let debitada = 0
            let aceptadaPago = 0

            let str = String.Format("INSERT INTO [2_orden_pago] 
            (cod_factura,cod_proveedor,cod_banco_proveedor,debitada,aceptada_pago,observaciones)
            VALUES ({0},{1},{2},{3},{4},'{5}')", codFactura,codProveedor,codBancoProveedor,debitada,aceptadaPago,observaciones )
            ExecuteCommands.execute str

        |    21 ->             // Inserta una registracion de pago
            let codOrden = parameters.[0] :?> int
            let fecha = parameters.[1] :?> string

            let str = String.Format("INSERT INTO [2_registracion_debito]
            (cod_orden_pago,fecha_registracion)
            VALUES ({0},'{1}')", codOrden,fecha)
            ExecuteCommands.execute str

         |    22 ->             // Inserta una cuenta bancaria de la empresa
            let cbu = parameters.[0] :?> int64
            let saldo = parameters.[1] :?> int
            let str = String.Format("INSERT INTO [2_cuenta_bancaria_empresa]
            (cbu,saldo)
            VALUES
            ({0},{1})", cbu,saldo)
            ExecuteCommands.execute str


        | _ ->              //Patron no encontrado
            MessageBox.Show("El numero enviado como parametro no coincide con ningun patron de insercion")
            |> ignore
    
     
module SelectCommands =
        
    // Registros completos
    let selectAll (option : int) =
        match option with
        | 200  ->               // Devuelve las Facturas para producir ordenes de pago
            let str = "SELECT 
            f.cod_factura AS [Codigo de factura],
            f.cod_ord_cpr AS [Orden de compra asociada],
            f.fecha_recepcion AS [Fecha de recepcion],
            f.importe AS [Importe],
            f.numero_factura AS [Numero de factura],
            f.observaciones AS [Observaciones]
            FROM 
	            (
		            SELECT * FROM 
		            [1_factura_proveedor] as ff
		            WHERE ff.cod_factura NOT IN 
		            (SELECT O.cod_factura FROM [2_orden_pago] AS O)
	            )
            AS f
            WHERE(f.sumada = 1)
            "
            Select.fillTables(str)

        | 201  ->               // Devuelve las Ordenes de pago
            let str = "SELECT 
            o.cod_orden_pago AS [Cod Orden de pago],
            o.cod_factura AS [Codigo de factura],
            o.cod_banco_proveedor AS [Banco de destino],
            o.cod_proveedor AS [Cod proveedor],
            o.cod_cuenta_bancaria AS [Cuenta desde donde se debita],
            o.debitada [Debitada],
            o.aceptada_pago [Procesada para pago],
            o.observaciones [Observaciones]
            FROM 
            [2_orden_pago] AS o
            "
            Select.fillTables(str)

        | 202->               // Devuelve las Ordenes de pago que esten aceptadas para pago y no tengan una registracion
            // Pero que esten aceptadas para pago
            let str = "SELECT
		    o.cod_orden_pago AS [Cod Orden de pago],
            o.cod_factura AS [Codigo de factura],
			f.importe AS [Importe a pagar],
            o.cod_banco_proveedor AS [Banco de destino],
            o.cod_proveedor AS [Cod proveedor],
            o.cod_cuenta_bancaria AS [Cuenta desde donde se debita],
            o.debitada [Debitada],
            o.aceptada_pago [Procesada para pago],
            o.observaciones [Observaciones]
			FROM
			(
			SELECT * 
            FROM 
            [2_orden_pago] AS o2
				WHERE o2.cod_orden_pago NOT IN (
				SELECT r.cod_orden_pago 
				FROM [2_registracion_debito] AS R
				)
		     )
            AS o
			INNER JOIN [1_factura_proveedor] AS f ON f.cod_factura = o.cod_factura
            WHERE (o.aceptada_pago = 1)
            "
            Select.fillTables(str)

        | 203  ->                 // Devuelve las registraciones de pagos
            let str = "SELECT 
            r.cod_registracion AS [Cod Registracion],
            r.cod_orden_pago AS [Cod Orden de pago],
            r.fecha_registracion AS [Fecha de registracion],
			f.importe AS [Importe registrado]
            FROM [2_registracion_debito] AS r
			INNER JOIN [2_orden_pago] AS o ON o.cod_orden_pago = r.cod_orden_pago
			INNER JOIN [1_factura_proveedor] AS f ON f.cod_factura = o.cod_factura
            "
            Select.fillTables(str)

        | 204  ->                 // Devuelve las ordenes de pago que no fueron aceptadas para pago
            let str = "SELECT
	        o.cod_orden_pago AS [Cod Orden de pago],
            o.cod_factura AS [Codigo de factura],
	        f.importe AS [Importe a pagar],
            o.cod_banco_proveedor AS [Banco de destino],
            o.cod_proveedor AS [Cod proveedor],
            o.cod_cuenta_bancaria AS [Cuenta desde donde se debita],
            o.debitada [Debitada],
            o.aceptada_pago [Procesada para pago],
            o.observaciones [Observaciones]
            FROM 
            [2_orden_pago] AS o		
		    INNER JOIN [1_factura_proveedor] AS f ON f.cod_factura = o.cod_factura
            WHERE		
		    (o.aceptada_pago = 0)
            "
            Select.fillTables(str)

        | 205  ->                 // Devuelve todas las cuentas bancarias de la empresa
            let str = "SELECT 
            C.cod_cuenta_bancaria AS [Codigo de cuenta],
            C.cbu AS [CBU],
            C.saldo as [Saldo]
            FROM
            [2_cuenta_bancaria_empresa] AS C
            "
            Select.fillTables(str)

    // Retorna una tabla con los registros que coincidan con la busqueda
    let selectOne (option : int, parameter : Object) =
        match option with
        |201  ->               // Devuelve las ordenes de compras que coincidan con el codigo entregado
            let codigo = parameter :?> int
            let str = String.Format("SELECT 
                    o.cod_orden_pago AS [Cod Orden de pago],
                    o.cod_factura AS [Codigo de factura],
                    o.cod_banco_proveedor AS [Banco de destino],
                    o.cod_proveedor AS [Cod proveedor],
                    o.cod_cuenta_bancaria AS [Cuenta desde donde se debita],
                    o.debitada [Debitada],
                    o.observaciones [Observaciones],
                    o.aceptada_pago [Procesada para pago]
                    FROM 
                    [2_orden_pago] AS o
                    WHERE (o.cod_orden_pago = {0})
                    ", codigo)
            Select.fillTables(str)
            
        |202  ->               // Devuelve las cuentas bancarias de los proveedores por su codigo
            let codigo = parameter :?> int
            let str = String.Format("SELECT
            c.cbu AS [Codigo de cuenta],
            c.cod_proveedor AS [Codigo de proveedor],
            p.nombre AS [Nombre proveedor]
            FROM [1_cbu_proveedor] AS c
            INNER JOIN [1_proveedor] as p ON c.cod_proveedor = p.cod_proveedor
            WHERE (c.cod_proveedor = {0})
                    ", codigo)
            Select.fillTables(str)

        |203  ->               // Devuelve las ordenes de pago por su codigo
            let codigo = parameter :?> int
            let str = String.Format("SELECT 
            o.cod_orden_pago AS [Cod Orden de pago],
            o.cod_factura AS [Codigo de factura],
            o.cod_banco_proveedor AS [Banco de destino],
            o.cod_proveedor AS [Cod proveedor],
            o.cod_cuenta_bancaria AS [Cuenta desde donde se debita],
            o.debitada [Debitada],
            o.aceptada_pago [Procesada para pago],
            o.observaciones [Observaciones]
            FROM 
            [2_orden_pago] AS o
            WHERE (o.cod_orden_pago = {0})
            ", codigo)
            Select.fillTables(str)

        | 204->               // Devuelve las Ordenes de pago que esten aceptadas para pago y no tengan una registracion
            // ( Por su codigo)
            let codigo = parameter :?> int
            let str = String.Format( "SELECT
		    o.cod_orden_pago AS [Cod Orden de pago],
            o.cod_factura AS [Codigo de factura],
			f.importe AS [Importe a pagar],
            o.cod_banco_proveedor AS [Banco de destino],
            o.cod_proveedor AS [Cod proveedor],
            o.cod_cuenta_bancaria AS [Cuenta desde donde se debita],
            o.debitada [Debitada],
            o.aceptada_pago [Procesada para pago],
            o.observaciones [Observaciones]
			FROM
			(
			SELECT * 
            FROM 
            [2_orden_pago] AS o2
				WHERE o2.cod_orden_pago NOT IN (
				SELECT r.cod_orden_pago 
				FROM [2_registracion_debito] AS R
				)
		     )
            AS o
			INNER JOIN [1_factura_proveedor] AS f ON f.cod_factura = o.cod_factura
            WHERE (o.aceptada_pago = 1 AND o.cod_orden_pago = {0})
            ", codigo)
            Select.fillTables(str)

        
        | 205->               // Devuelve las ordenes de pago que coincidan con un codigo de cuenta bancaria
            let codigo = parameter :?> int
            let str = String.Format( "SELECT * FROM [2_orden_pago] AS O
            WHERE (o.cod_cuenta_bancaria = {0})
            ", codigo)
            Select.fillTables(str)

        | 206->               // Devuelve las cuentas bancarias por su codigo
            let codigo = parameter :?> int
            let str = String.Format( "SELECT 
            C.cod_cuenta_bancaria AS [Codigo de cuenta],
            C.cbu AS [CBU]
            FROM
            [2_cuenta_bancaria_empresa] AS C
            WHERE (C.cod_cuenta_bancaria = {0})
            ", codigo)
            Select.fillTables(str)

        | 207->               // Devuelve las cuentas bancarias cuyo saldo sea mayor o igual a la cantidad ingresada
            let saldo = parameter :?> int
            let str = String.Format( "SELECT 
            C.cod_cuenta_bancaria AS [Codigo de cuenta],
            C.cbu AS [CBU],
            C.saldo [Saldo]
            FROM
            [2_cuenta_bancaria_empresa] AS C
            WHERE (C.saldo >= {0})
            ", saldo)
            Select.fillTables(str)

        | 208->               // Devuelve las cuentas bancarias cuyo saldo sea menor o igual a la cantidad ingresada
            let saldo = parameter :?> int
            let str = String.Format( "SELECT 
            C.cod_cuenta_bancaria AS [Codigo de cuenta],
            C.cbu AS [CBU],
            C.saldo [Saldo]
            FROM
            [2_cuenta_bancaria_empresa] AS C
            WHERE (C.saldo <= {0})
            ", saldo)
            Select.fillTables(str)

        | 209->               // Devuelve las cuentas bancarias cuyo saldo sea igual a la cantidad ingresada
            let saldo = parameter :?> int
            let str = String.Format( "SELECT 
            C.cod_cuenta_bancaria AS [Codigo de cuenta],
            C.cbu AS [CBU],
            C.saldo [Saldo]
            FROM
            [2_cuenta_bancaria_empresa] AS C
            WHERE (C.saldo = {0})
            ", saldo)
            Select.fillTables(str)

   
          
 

     // devuelve un codigo a partir de un valor que se sabe no está repetido
    let selecCode (option : int, field : Object) =
        match option with
        | 250 ->        // Devuelve el codigo de proveedor a traves de un codigo de factura
            // (Pedido de reaprovisionamiento)
            let  codFactura = field :?> int
            let str = String.Format("SELECT 
            pr.cod_proveedor
            FROM [1_factura_proveedor] AS f
            INNER JOIN [1_orden_compra] AS o ON o.cod_ord_cpr = f.cod_ord_cpr
            INNER JOIN [1_cotizacion_pedido_reaprovisionamiento] AS ctpr ON ctpr.cod_ord_cpr = o.cod_ord_cpr
            inner join [1_pedido_reaprovisionamiento] pr on pr.cod_pr = ctpr.cod_pr
            WHERE (f.cod_factura = {0})", codFactura)
            Select.selectCod(str)
        | 251 ->        // Devuelve el codigo de proveedor a traves de un codigo de factura
            // (Solicitud de compra)
            let  codFactura = field :?> int
            let str = String.Format("SELECT 
            scc.cod_proveedor
            FROM [1_factura_proveedor] AS f
            INNER JOIN [1_orden_compra] AS c ON c.cod_ord_cpr = f.cod_ord_cpr
            INNER JOIN [1_cotizacion_sc_oc] AS cc ON c.cod_ord_cpr = cc.cod_ord_cpr
            INNER JOIN [1_cotizacion_solicitud_compra] AS sc ON sc.cod_cotizacion = cc.cod_cotizacion
            INNER JOIN [1_cotizacion_sc] AS scc ON scc.cod_cotizacion = sc.cod_cotizacion
            WHERE (f.cod_factura = {0})", codFactura)
            Select.selectCod(str)




// Consultas de eliminacion
module Delete =
    // Elimina por codigo
    let rec deleteFrom (option : int, codigo : int) =
        match option with     
        | 2 ->                 // Elimina una confirmacion de cobro
            let str = String.Format("DELETE FROM [2_orden_pago] 
            WHERE (cod_orden_pago = {0})
            ",codigo)
            ExecuteCommands.execute(str)
            |> ignore

         | 3 ->                 // Elimina una cuenta bancaria
            let str = String.Format("DELETE FROM [2_cuenta_bancaria_empresa]
            WHERE (cod_cuenta_bancaria = {0})
            ",codigo)
            ExecuteCommands.execute(str)
            |> ignore