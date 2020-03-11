namespace DatosCobros

open System
open System.Data
open System.Windows.Forms
open Templates




module UpdateCommands =
    open System.Linq.Expressions
   
    // Modifica varios campos
    let updateMany (option : int, parameters :  Object[]) =
        match option with 
      

         | _ ->              //Patron no encontrado
            MessageBox.Show("El numero enviado como parametro no coincide con ningun patron de modificacion")
            |> ignore

    // modifica un solo campo
    let updateOne (option : int, cod : int, parameter : Object) =
        match option with
      
        | 40 ->             // 40 Modifica el debe de la cuenta corriente del cliente
            // Restando del debe el monto recibido en una confirmacion de cobro
            let str = String.Format("UPDATE [3_cuenta_corriente_cliente]
            SET debe = debe -
		                     (
		                     SELECT c.importe_recibido 
		                     FROM [4_confirmacion_cobro] AS c 
		                     WHERE c.cod_con_cob = {0}
		                     )
            WHERE cod_cli = 
	                         (
		                     SELECT p.cod_cli
		                     FROM [4_confirmacion_cobro] AS c
		                     INNER JOIN [3_factura_venta] AS f ON f.cod_fac_vent = c.cod_fac_vent
		                     INNER JOIN [3_remito_venta] AS r ON r.cod_rem_vent = f.cod_rem_vent
		                     INNER JOIN [3_pedido_venta] AS p ON p.cod_ped_vent = r.cod_ped_vent
		                     WHERE c.cod_con_cob = {0}
		                     )",cod)
            ExecuteCommands.execute str

        | 41 ->             // 40 Modifica el debe de la cuenta corriente del cliente
            // Restando del debe el monto recibido en una confirmacion de cobro
            let cuenta = parameter
            let str = String.Format("UPDATE [2_cuenta_bancaria_empresa]
            SET saldo = saldo +
		             (
		             SELECT c.importe_recibido 
		             FROM [4_confirmacion_cobro] AS c 
		             WHERE c.cod_con_cob = {0}
		             )
            WHERE cod_cuenta_bancaria = {1}",cod, cuenta)
            ExecuteCommands.execute str

        | _ ->              //Patron no encontrado
            MessageBox.Show("El numero enviado como parametro no coincide con ningun patron de modificacion")
            |> ignore
            
            
module InsertsCommands =
    open System.Data.SqlTypes
  

    let rec insertInto (option : int, parameters : Object[]) =
        match option with 
        
        | 40 ->             // Inserta una confirmacion de cobro
            let cod_fac_vent = parameters.[0] :?> int
            let cod_cuenta = parameters.[1] :?> int
            let fecha = parameters.[2] :?> string
            let importe = parameters.[3] :?> int

            let str = String.Format("INSERT INTO [4_confirmacion_cobro] (cod_fac_vent,cod_cuenta_bancaria,fecha_debitacion,importe_recibido)
            VALUES ({0},{1},'{2}',{3})", cod_fac_vent,cod_cuenta,fecha,importe )
            ExecuteCommands.execute str

        | 41 ->             // Inserta una registracion por cobro
            let cod_confirmacion = parameters.[0] :?> int
            let fecha = parameters.[1] :?> string

            let str = String.Format("INSERT INTO [4_registracion_monetaria] (cod_con_cob,fecha_registracion) 
            VALUES ({0},'{1}')", cod_confirmacion,fecha )
            ExecuteCommands.execute str

        | _ ->              //Patron no encontrado
            MessageBox.Show("El numero enviado como parametro no coincide con ningun patron de insercion")
            |> ignore
    
     
module SelectCommands =
        
    // Registros completos
    let selectAll (option : int) =
        match option with
        | 400  ->               // Devuelve las confirmaciones de cobro
            let str = " SELECT c.cod_con_cob AS [Cod Confirmacion],
            c.cod_cuenta_bancaria AS [Cuenta de la empresa],
            c.cod_fac_vent AS [Factura asociada],
            c.fecha_debitacion [Fecha de debito],
            c.importe_recibido [Importe recibido]
            FROM [4_confirmacion_cobro] AS C
            "
            Select.fillTables(str)
        
        | 401  ->                // Devuelve las registraciones de cobros
            let str = " SELECT r.cod_registracion AS [Codigo de registracion],
            r.cod_con_cob AS [Codigo de confirmacion],
            r.fecha_registracion AS [Fecha de registracion] 
            FROM [4_registracion_monetaria] AS r
            "
            Select.fillTables(str)

        | 402  ->                // Devuelve todas las cuentas corrientes de la empresa
            let str = "SELECT c.cod_cuenta_bancaria AS [Codigo de cuenta],
            c.cbu AS [CBU de la cuenta]
            FROM [2_cuenta_bancaria_empresa] AS c
            "
            Select.fillTables(str)
        | 403  ->                // Devuelve todas las facturas con campo sumada true y no tienen una confirmacion de cobro
            let str = "SELECT f.cod_fac_vent AS [Cod factura],
            f.cod_rem_vent AS [Cod Remito],
            f.importe AS [Importe],
            f.observaciones AS [Observaciones]
            FROM
            [3_factura_venta] AS F
            WHERE f.sumada = 1
            "
            Select.fillTables(str)

         | 404  ->                // Devuelve todas las confimaciones de cobros que no tienen registracion
            let str = "SELECT c.cod_con_cob AS [Cod Confirmacion],
            c.cod_cuenta_bancaria AS [Cuenta de la empresa],
            c.cod_fac_vent AS [Factura asociada],
            c.fecha_debitacion [Fecha de debito],
            c.importe_recibido [Importe recibido]
            FROM[4_confirmacion_cobro] AS c
            WHERE c.cod_con_cob NOT IN 
	        (SELECT r.cod_con_cob FROM [4_registracion_monetaria] AS r)
            "
            Select.fillTables(str)



            // Retorna una tabla con los registros que coincidan con la busqueda
    let selectOne (option : int, parameter : Object) =
        match option with
        | 500 ->       //devuelve una confirmacion de cobro por el codigo
            let codigo = parameter :?> int
            let str =  String.Format(" SELECT c.cod_con_cob AS [Cod Confirmacion],
            c.cod_cuenta_bancaria AS [Cuenta de la empresa],
            c.cod_fac_vent AS [Factura asociada],
            c.fecha_debitacion [Fecha de debito],
            c.importe_recibido [Importe recibido]
            FROM [4_confirmacion_cobro] AS C
            WHERE c.cod_con_cob = {0}
            ", codigo)
            Select.fillTables(str)

        | 501 ->     // Devuelve una confirmacion de cobro por el codigo de cuenta corriente
            let codigo = parameter :?> int
            let str =  String.Format(" SELECT c.cod_con_cob AS [Cod Confirmacion],
            c.cod_cuenta_bancaria AS [Cuenta de la empresa],
            c.cod_fac_vent AS [Factura asociada],
            c.fecha_debitacion [Fecha de debito],
            c.importe_recibido [Importe recibido]
            FROM [4_confirmacion_cobro] AS C
            WHERE c.cod_cuenta_bancaria = {0}
            ", codigo)
            Select.fillTables(str)

        | 502  ->                // Devuelve las registraciones de cobros por su codigo
            let codigo = parameter :?> int
            let str = String.Format( " SELECT r.cod_registracion AS [Codigo de registracion],
            r.cod_con_cob AS [Codigo de confirmacion],
            r.fecha_registracion AS [Fecha de registracion] 
            FROM [4_registracion_monetaria] AS r
            WHERE r.cod_registracion = {0}
            ", codigo)
            Select.fillTables(str)


        //  Devuelve el codigo si existe, si no devuelve 0.
    let selecCode (option : int, field : Object) =
        match option with
        | 600 ->        // Devuelve el codigo de una confirmacion de cobro.
            let confirmacion = field :?> int
            let str = String.Format("SELECT r.cod_con_cob
            FROM [4_registracion_monetaria] AS r
            WHERE (r.cod_con_cob = {0})", confirmacion)
            Select.selectCod(str)
        

// Consultas de eliminacion


module Delete =
    // Elimina por codigo
    let rec deleteFrom (option : int, codigo : int) =
        match option with     
        | 4 ->                 // Elimina una confirmacion de cobro
            let str = String.Format("DELETE FROM 
            [4_confirmacion_cobro] 
            WHERE (cod_con_cob = {0})",codigo)
            ExecuteCommands.execute(str)
            |> ignore