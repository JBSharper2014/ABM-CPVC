
namespace DatosVentas

open System
open System.Data
open System.Windows.Forms
open Templates




module UpdateCommands =
   
    // Modifica varios campos
    let updateMany (option : int, parameters :  Object[]) =
        match option with 
        | 300000 ->         // 300000 Modifica un cliente
            let cod_cli = parameters.[0] :?> int
            let nombre = parameters.[1] :?> string
            let apellido = parameters.[2] :?> string
            let telefono = parameters.[3] :?> string
            let cod_dir = parameters.[4] :?> int    
            let cod_ciu = parameters.[5] :?> int
            let calle = parameters.[6] :?> string
            let numero = parameters.[7] :?> string
            let esquina = parameters.[8] :?> string
            let str1 = String.Format("UPDATE [3_cliente] SET nombre = '{0}', apellido = '{1}', telefono = '{2}' WHERE cod_cli = {3}", nombre,apellido,telefono,cod_cli);
            let str2 = String.Format("UPDATE [1_direccion] SET cod_ciu = {0}, calle = '{1}', numero = '{2}', esquina = '{3}' WHERE cod_dir = {4}", cod_ciu,calle,numero,esquina,cod_dir);
            ExecuteCommands.execute str1
            ExecuteCommands.execute str2
            

        | 300001 ->         // 300001 Modifica un pedido de venta (producto y cantidad)
            let cod_stock = parameters.[0] :?> int
            let cod_vent = parameters.[1] :?> int
            let cantidad = parameters.[2] :?> int
            let str = String.Format("UPDATE [3_stock_venta] SET cantidad = {0} WHERE (cod_pro_stock = {1}) AND (cod_ped_vent = {2})", cantidad,cod_stock,cod_vent)
            ExecuteCommands.execute str

         | _ ->              //Patron no encontrado
            MessageBox.Show("El numero enviado como parametro no coincide con ningun patron de modificacion")
            |> ignore

    // modifica un solo campo
    let updateOne (option : int, cod : int, parameter : Object) =
        match option with
        | 400000 ->        // 400000 Modifica a true "sumada" en una factura
            let sumada = true
            let str = String.Format("UPDATE [3_factura_venta] SET sumada = {0} WHERE cod_fac_vent = {1}",sumada,cod)
            ExecuteCommands.execute str

        | 400001 ->        // 400001 Modifica a true "sumada" en una factura
            let sumada = true
            let str = String.Format("UPDATE [3_factura_venta] SET sumada = {0} WHERE cod_fac_vent = {1}",sumada,cod)
            ExecuteCommands.execute str

        | 400002 ->       // 400002 Modifica el precio de venta de un producto
            let precioaux = parameter :?> string
            let precio = precioaux.Replace(",",".")
            let str = String.Format("UPDATE [1_stock] SET precio = {0} WHERE cod_pro_stock = {1}",precio,cod)
            ExecuteCommands.execute str

        | 400003 ->       // 400003 Modifica el estado de pedido de devolucion cuando se devuelve el producto
            let str = String.Format("UPDATE [3_devolucion_venta] SET estado = 'Finalizado con producto devuelto' WHERE cod_pro_stock = {0}",cod)
            ExecuteCommands.execute str

        | 400004 ->       // 400004 Modifica el estado de pedido de devolucion cuando se genera una nota de credito
            let str = String.Format("UPDATE [3_devolucion_venta] SET estado = 'Nota de credito por sumar' WHERE cod_dev_vent = {0}",cod)
            ExecuteCommands.execute str

        | 400005 ->       // 400005 Modifica un pedido de venta a procesado
            let str = String.Format("UPDATE [3_pedido_venta] SET procesado = 1 WHERE cod_ped_vent = {0}",cod)
            ExecuteCommands.execute str

        | 400006 ->       // 400005 Modifica stock restando la cantidad a un producto
            let cantidad = parameter :?> int
            let str = String.Format("UPDATE [1_stock] SET stk_act = stk_act - {0} WHERE cod_pro_stock = {1}", cantidad ,cod)
            ExecuteCommands.execute str

        | 400007 ->       // 400007 Modifica el estado de pedido de devolucion cuando se borra una nota de credito que no se sumó
            let str = String.Format("UPDATE [3_devolucion_venta] SET estado = 'Devolucion por credito' WHERE cod_dev_vent = {0}",cod)
            ExecuteCommands.execute str

        | 400008 ->       // 400008 Modifica el campo de la factura sumada a true
            let str = String.Format("UPDATE [3_factura_venta] SET sumada = 1 WHERE cod_fac_vent = {0}",cod)
            ExecuteCommands.execute str

        | 400009 ->       // 400009 Modifica el campo de nota de credito sumado a true
            let str = String.Format("UPDATE [3_nota_credito_cliente] SET sumado = 1 WHERE cod_nc_vent = {0}",cod)
            ExecuteCommands.execute str

        | 400010 ->      // 400010 Suma el debe en una cuenta corriente de cliente
            let importe = parameter :?> int
            let str = String.Format("UPDATE [3_cuenta_corriente_cliente] SET debe = debe + {0} WHERE cod_cta_cli = {1}",importe,cod)
            ExecuteCommands.execute str

        | 400011 ->      // 400010 Suma el debe en una cuenta corriente de cliente
            let importe = parameter :?> int
            let str = String.Format("UPDATE [3_cuenta_corriente_cliente] SET haber = haber + {0} WHERE cod_cta_cli = {1}",importe,cod)
            ExecuteCommands.execute str

        | _ ->              //Patron no encontrado
            MessageBox.Show("El numero enviado como parametro no coincide con ningun patron de modificacion")
            |> ignore
            
            
module InsertsCommands =
    open System.Data.SqlTypes
  

    let rec insertInto (option : int, parameters : Object[]) =
        match option with 
        | 300 ->            // 300 Inserta un cliente
              
            let nombre = parameters.[4] :?> string
            let apellido = parameters.[5] :?> string
            let telefono = parameters.[6] :?> string
            insertInto( 301, parameters)
            let cod_dir = Select.selectCod "SELECT TOP 1 cod_dir FROM [1_direccion] ORDER BY cod_dir DESC" 
            let str = String.Format ("INSERT INTO [3_cliente] (nombre,apellido,cod_dir,telefono) VALUES ('{0}','{1}',{2},'{3}')",nombre,apellido,cod_dir,telefono)
            ExecuteCommands.execute str |> ignore
                           
        | 301 ->            // 301 Apoya a el insert 300
            let cod_ciu = parameters.[0] :?> int
            let calle = parameters.[1] :?> string
            let numero = parameters.[2] :?> string
            let esquina = parameters.[3] :?> string
            let str = String.Format ("INSERT INTO [1_direccion] (cod_ciu, calle, numero, esquina) VALUES ({0},'{1}','{2}','{3}')", cod_ciu, calle, numero, esquina)
            ExecuteCommands.execute str |> ignore

        | 302 ->           // 302 Inserta una cuenta corriente
            let cod_cli = parameters.[0] :?> int 
            let debe = parameters.[1] :?> double
            let haber = parameters.[2] :?> double
            let str = String.Format ("INSERT INTO [3_cuenta_corriente_cliente] (cod_cli,debe,haber) VALUES ({0},{1},{2})",cod_cli,debe,haber)
            ExecuteCommands.execute(str) |> ignore

        | 303 ->           // 303 Inserta precio a un producto
            let codpro = parameters.[0] :?> int
            let precio = parameters.[1] :?> double
            let str = String.Format("INSERT INTO [1_stock] (precio) VALUES ({0}) WHERE (cod_pro_stock = {2})", precio, codpro)
            ExecuteCommands.execute str |> ignore

        | 304 ->           // 304 Inserta un pedido de venta
            let cod_cli = parameters.[0] :?> int
            let fecha = parameters.[1] :?> string
            let procesado = false
            let str = String.Format("INSERT INTO [3_pedido_venta] (cod_cli, fecha_emision,procesado) VALUES ({0},'{1}',{2})",cod_cli,fecha,0)
            ExecuteCommands.execute str
            |> ignore
          
                      
        | 305 ->           // 305 Inserta todos los productos y cantidades que están en el pedido de venta.
            let cantidad = parameters.[2] :?> int[]
            let productos = parameters.[3] :?> int[]
            let producto_cantidad = Array.zip productos cantidad
            let codigo_pedido = Select.selectCod "SELECT TOP 1 cod_ped_vent FROM [3_pedido_venta] ORDER BY [cod_ped_vent] DESC"
            for (i,j) in producto_cantidad do MessageBox.Show((i,j).ToString()) 
            for (i,j) in producto_cantidad do   
                ExecuteCommands.execute (String.Format ("INSERT INTO [3_stock_venta] (cod_pro_stock,cod_ped_vent,cantidad) VALUES ({0},{1},{2})", j, codigo_pedido ,i))
                |> ignore
        
        | 306 ->          // 306 Inserta un remito por venta 
            let cod_ped = parameters.[0] :?> int
            let observaciones = parameters.[1] :?> string
            let devolucion = if (parameters.[2] :?> bool) then 1
                             else 0
            let fecha = parameters.[3] :?> string
            let cod_dev = parameters.[4] :?> int
            let str = String.Format("INSERT INTO [3_remito_venta] (cod_ped_vent,observaciones,es_devolucion,fecha_creacion) VALUES ({0},'{1}',{2},'{3}')",cod_ped,observaciones,devolucion,fecha)
            ExecuteCommands.execute str
            if devolucion = 1 then  UpdateCommands.updateOne(400003, cod_ped, "Parametro de relleno")
            else  UpdateCommands.updateOne(400005,cod_ped, "Parametro de relleno")
            |> ignore
        
        | 307 ->             // 307 Inserta una devolucion por venta 
            let cod_rem = parameters.[0] :?> int
            let cod_pro = parameters.[1] :?> int
            let cantidad = parameters.[2] :?> int
            let problemas = parameters.[3] :?> string
            let estado = parameters.[4] :?> string
            let fecha = parameters.[5] :?> string
            let str = String.Format("INSERT INTO [3_devolucion_venta] (cod_rem_vent,cod_pro_stock,cantidad,problemas,estado,fecha_creacion) VALUES ({0},{1},{2},'{3}','{4}','{5}')",cod_rem,cod_pro, cantidad,problemas,estado,fecha )
            ExecuteCommands.execute str
            |> ignore

        | 308 ->             // 308 Inserta una factura por venta
            let cod_rem = parameters.[0] :?> int
            let importeaux = parameters.[1] :?> string
            let importe = importeaux.Replace(",",".")
            let observaciones = parameters.[2] :?> string
            let sumada = parameters.[3] :?> int
            let str = String.Format("INSERT INTO [3_factura_venta] (cod_rem_vent, importe, observaciones, sumada) VALUES ({0},{1},'{2}',{3})",cod_rem,importe,observaciones,sumada)
            ExecuteCommands.execute str
            |> ignore

        | 309 ->             // 309 Inserta una nota de credito 
            let cod_dev = parameters.[0] :?> int
            let sumado = 0
            let importeaux = parameters.[1] :?> string
            let importe = importeaux.Replace(",",".")
            let str = String.Format("INSERT INTO [3_nota_credito_cliente] (cod_dev_vent,sumado,importe) VALUES ({0},{1},{2})",cod_dev,sumado,importe)
            ExecuteCommands.execute str
            |> ignore

        | 310 ->            // 310 Inserta una registracion
            let cod_fac = parameters.[0] :?> int
            let cod_nc = parameters.[1] :?> int 
            let cod_cta_cli = parameters.[2] :?> int
            let str =
                if (cod_nc = 0) then String.Format("INSERT INTO [3_registracion_venta] (cod_fac_vent,cod_cta_cli) VALUES ({0},{1})",cod_fac,cod_cta_cli)
                else String.Format("INSERT INTO [3_registracion_venta] (cod_nc_vent,cod_cta_cli) VALUES ({0},{1})",cod_nc,cod_cta_cli)
            ExecuteCommands.execute str
            |> ignore
        
        | _ ->              //Patron no encontrado
            MessageBox.Show("El numero enviado como parametro no coincide con ningun patron de insercion")
            |> ignore
    
     
module SelectCommands =
        
    // Registros completos
    let selectAll (option : int) =
        match option with
        | 3000 ->           // 3000 Devuelve clientes
            let str = "
            SELECT 
            c.cod_cli AS Codigo, c.nombre AS Nombre, c.apellido AS Apellido, c.telefono AS Telefono, p.nombre AS Provincia,
            ciu.nombre AS Ciudad, dir.calle AS Calle, dir.numero AS Numero, dir.esquina AS Esquina
            FROM       [3_cliente]   AS c 
            INNER JOIN [1_direccion] AS dir ON c.cod_dir = dir.cod_dir
            INNER JOIN [1_ciudad]    AS ciu ON dir.cod_ciu = ciu.cod_ciu
            INNER JOIN [1_provincia] AS p   ON p.cod_provincia = ciu.cod_provincia"
            Select.fillTables(str)
        
        | 3001 ->          // 3001 devuelve cuentas corrientes de clientes
            let str = "
            SELECT
            c.cod_cli AS Codigo, c.nombre AS Nombre, c.apellido AS Apellido,
            d.debe AS Debe, d.haber AS Haber
            FROM       [3_cliente]   AS c 
            INNER JOIN [3_cuenta_corriente_cliente] AS d ON c.cod_cli = d.cod_cli"
            Select.fillTables(str)

        | 3002 ->          // Devuelve los productos comprados con fecha mas reciente y su coste.
            let str = "
            SELECT Stk.cod_pro_stock AS [Codigo de producto],
            Stk.nombre AS [Producto],
            Mar.nombre AS [Marca], 
            med.nombre AS [Medida],
            Stk.precio AS [Precio actual],
            Cpr.precio_cotizado AS [Precio de compra],
            Oc.fecha_emision AS [Fecha de compra]
            FROM [1_stock] AS Stk 
            INNER JOIN [1_stock_marca] AS StkMark ON StkMark.cod_pro_stock = Stk.cod_pro_stock
            INNER JOIN [1_marca] AS Mar ON Mar.cod_mar = StkMark.cod_mar 
            INNER JOIN [1_medida] AS Med ON Stk.cod_cat = med.cod_cat
            INNER JOIN [1_cotizacion_pedido_reaprovisionamiento] AS Cpr ON Cpr.cod_pro_stock = Stk.cod_pro_stock
            INNER JOIN ( SELECT * FROM [1_orden_compra] AS oC 
			             WHERE  fecha_emision = (SELECT MAX(fecha_emision) FROM [1_orden_compra]) 
            ) AS Oc ON Oc.cod_ord_cpr = Cpr.cod_ord_cpr "
            Select.fillTables(str)

        | 3003 ->         // devuelve todas las provincias
            let str = "SELECT nombre FROM [1_provincia]"
            Select.fillTables(str)

        | 3004 ->         // devuelve todos los pedidos de venta
            let str = "SELECT cod_ped_vent AS [Codigo de pedido], cod_cli AS [Codigo de cliente],
                       fecha_emision AS [Fecha de creación], procesado AS [Procesado] FROM [3_pedido_venta]"
            Select.fillTables(str)

        | 3005 ->         // Devuelve el producto con su precio unitario (si tiene precio)
            let str = "
                SELECT Stk.cod_pro_stock AS [Codigo],
                Stk.nombre AS [Producto],
                Mar.nombre AS [Marca], 
                med.nombre AS [Medida],
                Stk.precio AS [Precio unitario]
                FROM [1_stock] AS Stk 
                INNER JOIN [1_stock_marca] AS StkMark ON StkMark.cod_pro_stock = Stk.cod_pro_stock
                INNER JOIN [1_marca] AS Mar ON Mar.cod_mar = StkMark.cod_mar 
                INNER JOIN [1_medida] AS Med ON Stk.cod_cat = med.cod_cat
                WHERE stk.precio IS NOT NULL
                "
            Select.fillTables(str)

        | 3006 ->         // devuelve todos los pedidos de venta que no estan procesados
            let str = "SELECT cod_ped_vent AS [Codigo de pedido], cod_cli AS [Codigo de cliente],
                       fecha_emision AS [Fecha de creación], procesado AS [Procesado]
                       FROM [3_pedido_venta]
                       WHERE (procesado = 0)"
            Select.fillTables(str)

        | 3007 ->       // Devuelve todos los remitos
                 let str = "SELECT cod_rem_vent AS [Codigo de remito], cod_ped_vent AS [Pedido de venta asociado],
                 observaciones AS Observaciones, es_devolucion [Es por una devolucion], fecha_creacion AS [Fecha de creacion]
                 FROM [3_remito_venta]
                 "
                 Select.fillTables(str)
        
        | 3008 ->       // Devuelve todos los pedidos de devoluciones que tengan como estado // "Devolucion por producto"

                 let str = " SELECT cod_dev_vent AS [Codigo de devolucion], cod_rem_vent AS [Remito al que pertenece],
                 cod_pro_stock [Codigo de producto a devolver], cantidad AS [Cantidad],
                 problemas [Problemas encontrados], fecha_creacion AS [Fecha de creacion]
                 FROM [3_devolucion_venta]
                 WHERE(estado = 'Devolucion por producto')
                 "
                 Select.fillTables(str)

        | 3009 ->       // Devuelve todos los remitos que no tengan una factura asociada 
                 let str = "SELECT cod_rem_vent AS [Codigo de remito], cod_ped_vent AS [Pedido de venta asociado],
                            observaciones AS Observaciones, es_devolucion [Es por una devolucion],
				            fecha_creacion AS [Fecha de creacion]
                            FROM [3_remito_venta] AS r
                            WHERE NOT EXISTS 
                            (SELECT cod_rem_vent FROM [3_factura_venta] AS f WHERE (r.cod_rem_vent = f.cod_rem_vent))"
                 Select.fillTables(str)      

        | 3010 ->   // Devuelve todas las facturas 
                 let str = "SELECT cod_fac_vent AS [Codigo de factura], cod_rem_vent [Remito asociado], importe AS Importe,
                 observaciones AS Observaciones, sumada AS Procesada
                 FROM [3_factura_venta]"
                 Select.fillTables(str)      

        | 3011 ->       // Devuelve todos los pedidos de devoluciones

                 let str = " SELECT cod_dev_vent AS [Codigo de devolucion], cod_rem_vent AS [Remito al que pertenece],
                 cod_pro_stock [Codigo de producto a devolver], cantidad AS [Cantidad],
                 problemas [Problemas encontrados], fecha_creacion AS [Fecha de creacion],
                 estado [Estado de la devolucion]
                 FROM [3_devolucion_venta]
                 "
                 Select.fillTables(str)

        | 3012 ->       // Devuelve todos los remitos que no sean por devolucion
                 let str = "SELECT cod_rem_vent AS [Codigo de remito], cod_ped_vent AS [Pedido de venta asociado],
                 observaciones AS Observaciones, es_devolucion [Es por una devolucion], fecha_creacion AS [Fecha de creacion]
                 FROM [3_remito_venta]
                 WHERE(es_devolucion = 0)
                 "
                 Select.fillTables(str)

        | 3013 ->       // Devuelve todos los pedidos de devoluciones que tengan como estado // "Devolucion por credito"
                 let str = " SELECT cod_dev_vent AS [Codigo de devolucion], cod_rem_vent AS [Remito al que pertenece],
                 cod_pro_stock [Codigo de producto a devolver], cantidad AS [Cantidad],
                 problemas [Problemas encontrados], fecha_creacion AS [Fecha de creacion]
                 FROM [3_devolucion_venta]
                 WHERE(estado = 'Devolucion por credito')
                 "
                 Select.fillTables(str)
               
        | 3014 ->       // Devuelve todas las notas de credito
                 let str = "SELECT n.cod_nc_vent AS [Codigo nota de credito],
                            n.cod_dev_vent AS [Codigo de devolucion],
                            n.importe AS Importe,
                            n.sumado AS Procesado
                            FROM [3_nota_credito_cliente] AS n"
                 Select.fillTables(str)

        | 3015 ->       // Devuelve todas las notas de credito cuyo campo sumado sea false
                let str = "SELECT n.cod_nc_vent AS [Codigo nota de credito],
                            n.cod_dev_vent AS [Codigo de devolucion],
                            n.importe AS Importe,
                            n.sumado AS Procesado
                            FROM [3_nota_credito_cliente] AS n
                            WHERE (n.sumado = 0)"
                Select.fillTables(str)
        
        | 3016 ->       // Devuelve todas las facturas cuyo campo sumada sea false
                 let str = "SELECT cod_fac_vent AS [Codigo de factura], cod_rem_vent [Remito asociado], importe AS Importe,
                 observaciones AS Observaciones, sumada AS Procesada
                 FROM [3_factura_venta]
                 WHERE (sumada = 0)"
                 Select.fillTables(str) 

        | 3017 ->      // Devuelve todas las registraciones
                 let str = "SELECT cod_reg_vent AS [Cod registracion],
                 cod_fac_vent AS [Cod Factura],
                 cod_nc_vent as [Cod Nota de credito],
                 cod_cta_cli AS [Cod cuenta del cliente]
                 FROM [3_registracion_venta]"
                 Select.fillTables(str) 
        | _ ->              //Patron no encontrado
            MessageBox.Show("El numero enviado como parametro no coincide con ningun patron de consulta") |> ignore
            let table = new DataTable() 
            table 
    
    // True o False si existe
    let selectExist (option : int, cod : int ) =
        match option with
        | 4000 ->           // 4000 TRUE Si existe una cuenta asociada a ese cliente
            let str = String.Format ("SELECT cod_cli FROM [3_cuenta_corriente_cliente] WHERE (cod_cli = {0})", cod)
            Select.selectExist(str)

        | 4001 ->           // 4001 TRUE Si existe algun pedido de venta asociado a un cliente
            let str = String.Format("SELECT cod_cli FROM [3_pedido_venta] WHERE (cod_cli = {0})", cod)
            Select.selectExist(str)

        | _ ->              //Patron no encontrado
            MessageBox.Show("El numero enviado como parametro no coincide con ningun patron de busqueda por existencia") |> ignore
            false
    
    // Revisa un campo que se sabe que existe que contiene un bool y devuelve su contenido
    let selectCheckState (option : int, cod : int) =
        match option with
        | 5000 ->          // 5000 Revisa si procesado de pedido de venta
            let str = String.Format("SELECT procesado FROM [3_pedido_venta] WHERE (cod_ped_vent = {0})", cod)
            Select.selectExist(str)

    // retorna un string derivado de una consulta
    let selectReturnString (option : int, cod : int) =
        match option with
        | 6000 ->            // Revisa el Estado de pedido de devolucion
            let str = String.Format("SELECT estado FROM [3_devolucion_venta] WHERE (cod_dev_vent = {0})", cod)
            Select.returnString(str)
        
    
    // Retorna una tabla con los registros que coincidan con la busqueda
    let selectOne (option : int, parameter : Object) =
        match option with
        | 7000 ->       //devuelve un producto para ponerle el precio
            let texto = parameter :?> String
            let str =  String.Format(
                        "SELECT Stk.cod_pro_stock AS [Codigo de producto],
                        Stk.nombre AS [Producto], med.nombre AS [Medida],
                        Mar.nombre AS [Marca],
                        Stk.precio AS [Precio actual],
                        Cpr.precio_cotizado AS [Precio de compra],
                        Oc.fecha_emision AS [Fecha de compra]
                        FROM [1_stock] AS Stk 
                        INNER JOIN [1_stock_marca] AS StkMark ON StkMark.cod_pro_stock = Stk.cod_pro_stock
                        INNER JOIN [1_marca] AS Mar ON Mar.cod_mar = StkMark.cod_mar 
                        INNER JOIN [1_medida] AS Med ON Stk.cod_cat = med.cod_cat
                        INNER JOIN [1_cotizacion_pedido_reaprovisionamiento] AS Cpr ON Cpr.cod_pro_stock = Stk.cod_pro_stock
                        INNER JOIN [1_cotizacion_pr_oc] AS CotOc ON CotOc.cod_cotizacion = Cpr.cod_cotizacion
                        INNER JOIN ( SELECT TOP 1 * FROM [1_orden_compra] AS oC 
			                         WHERE  fecha_emision = (SELECT MAX(fecha_emision) FROM [1_orden_compra]) 
                        ) AS Oc ON Oc.cod_ord_cpr = CotOc.cod_ord_cpr
                        WHERE Stk.nombre LIKE '{0}' +'%'; ",texto)
            Select.fillTables(str)

        | 7001 ->   // devuelve las ciudades
            let  provincia = parameter :?> int
            let  str = String.Format("SELECT nombre FROM [1_ciudad] WHERE cod_provincia = {0}",provincia)
            Select.fillTables(str)

        | 7002 ->  // Devuelve cliente por codigo
            let codigo = parameter :?> int
            let str = String.Format("
                        SELECT 
                        c.cod_cli AS Codigo, c.nombre AS Nombre, c.apellido AS Apellido, c.telefono AS Telefono, p.nombre AS Provincia,
                        ciu.nombre AS Ciudad, dir.calle AS Calle, dir.numero AS Numero, dir.esquina AS Esquina
                        FROM       [3_cliente]   AS c 
                        INNER JOIN [1_direccion] AS dir ON c.cod_dir = dir.cod_dir
                        INNER JOIN [1_ciudad]    AS ciu ON dir.cod_ciu = ciu.cod_ciu
                        INNER JOIN [1_provincia] AS p   ON p.cod_provincia = ciu.cod_provincia
                        WHERE c.cod_cli = {0}", codigo)
            Select.fillTables(str)

        | 7003 ->  // Devuelve un producto especifico por su nombre con precio, marca y medida.
            let texto = parameter :?> string
            let str = String.Format("
                        SELECT Stk.cod_pro_stock AS [Codigo],
                        Stk.nombre AS [Producto],
                        Mar.nombre AS [Marca], 
                        med.nombre AS [Medida],
                        Stk.precio AS [Precio unitario]
                        FROM [1_stock] AS Stk 
                        INNER JOIN [1_stock_marca] AS StkMark ON StkMark.cod_pro_stock = Stk.cod_pro_stock
                        INNER JOIN [1_marca] AS Mar ON Mar.cod_mar = StkMark.cod_mar 
                        INNER JOIN [1_medida] AS Med ON Stk.cod_cat = med.cod_cat
                        WHERE Stk.nombre LIKE '{0}' +'%'; ", texto)
            Select.fillTables(str)

        | 7004 -> // devuelve todos los productos cargados en un pedido de venta por su codigo
            let codigo_pedido = parameter :?> int
            let str = String.Format("
                        SELECT P.cod_pro_stock AS Codigo, Stk.nombre AS Nombre, P.cantidad AS Cantidad
                        FROM [3_stock_venta] AS P
                        INNER JOIN [1_stock] AS STK ON Stk.cod_pro_stock = P.cod_pro_stock
                        WHERE cod_ped_vent = {0}", codigo_pedido)
            Select.fillTables(str)

        | 7005 -> // devuelve todos los remitos cargados por codigo de remito
            let codigo_remito = parameter :?> int
            let str = String.Format("
                        SELECT cod_rem_vent AS [Codigo de remito], cod_ped_vent AS [Pedido de venta asociado],
                        observaciones AS Observaciones, es_devolucion [Es por una devolucion], fecha_creacion AS [Fecha de creacion]
                        FROM [3_remito_venta]
                        WHERE cod_rem_vent = {0}", codigo_remito)
            Select.fillTables(str)
        
         | 7006 -> // devuelve todos los remitos cargados por nombre de cliente
            let nombre_cliente = parameter :?> string
            let str = String.Format("
                        SELECT r.cod_rem_vent AS [Codigo de remito], r.cod_ped_vent AS [Pedido de venta asociado],
                        r.observaciones AS Observaciones, r.es_devolucion [Es por una devolucion],
                        r.fecha_creacion AS [Fecha de creacion]
                        FROM [3_remito_venta] AS r
                        INNER JOIN [3_pedido_venta] AS p ON p.cod_ped_vent = r.cod_ped_vent
                        INNER JOIN [3_cliente] AS c ON c.cod_cli = p.cod_cli
                        WHERE c.nombre LIKE '{0}' +'%';", nombre_cliente)
            Select.fillTables(str)

        | 7007 -> // Devulve los pedidos de venta sin procesar por nombre de cliente.           
            let nombre_cliente = parameter :?> string
            let str = String.Format("
                        SELECT p.cod_ped_vent AS [Codigo de pedido], p.cod_cli AS [Codigo de cliente],
                        p.fecha_emision AS [Fecha de creación], p.procesado AS [Procesado]
                        FROM [3_pedido_venta] AS p
                        INNER JOIN [3_cliente] AS c ON c.cod_cli = p.cod_cli
                        WHERE (p.procesado = 0 AND c.nombre LIKE '{0}' +'%')", nombre_cliente)
            Select.fillTables(str)

        | 7008 -> // IDEM 7004 pero sin el nombre del producto
            let codigo_pedido = parameter :?> int
            let str = String.Format("
                        SELECT P.cod_pro_stock AS Codigo, P.cantidad AS Cantidad
                        FROM [3_stock_venta] AS P
                        WHERE cod_ped_vent = {0}", codigo_pedido)
            Select.fillTables(str)

        | 7009 ->  //  IDEM 7002 pero por cualquier caracter
            let caracter = parameter :?> string
            let str = String.Format("
                        SELECT 
                        c.cod_cli AS Codigo, c.nombre AS Nombre, c.apellido AS Apellido, c.telefono AS Telefono, p.nombre AS Provincia,
                        ciu.nombre AS Ciudad, dir.calle AS Calle, dir.numero AS Numero, dir.esquina AS Esquina
                        FROM       [3_cliente]   AS c 
                        INNER JOIN [1_direccion] AS dir ON c.cod_dir = dir.cod_dir
                        INNER JOIN [1_ciudad]    AS ciu ON dir.cod_ciu = ciu.cod_ciu
                        INNER JOIN [1_provincia] AS p   ON p.cod_provincia = ciu.cod_provincia
                        WHERE c.nombre LIKE '{0}' +'%'", caracter)
            Select.fillTables(str)


        | 7010 -> // devuelve todos los productos cargados en un pedido de venta por su codigo, cantidad pedida y precio unitario del articulo
            let codigo_pedido = parameter :?> int
            let str = String.Format("
                        SELECT P.cod_pro_stock AS Codigo, Stk.precio AS Precio ,P.cantidad AS Cantidad
                        FROM [3_stock_venta] AS P
                        INNER JOIN [1_stock] AS STK ON Stk.cod_pro_stock = P.cod_pro_stock
                        WHERE cod_ped_vent = {0}", codigo_pedido)
            Select.fillTables(str)

        | 7011 -> // Devuelve todas las devoluciones por un codigo especifico
           let codigo_devolucion = parameter :?> int
           let str = String.Format("SELECT cod_dev_vent AS [Codigo de devolucion], cod_rem_vent AS [Remito al que pertenece],
                         cod_pro_stock [Codigo de producto a devolver], cantidad AS [Cantidad],
                         problemas [Problemas encontrados], fecha_creacion AS [Fecha de creacion],
                         estado [Estado de la devolucion]
                         FROM [3_devolucion_venta]
                         WHERE cod_dev_vent = {0}",codigo_devolucion )
           Select.fillTables(str)

        | 7012 ->   // Devuelve el importe que deberá tener una nota de credito por un codigo de devolucion proprcionado
           let codigo_devolucion = parameter :?> int
           let str = String.Format("SELECT stk.precio * d.cantidad AS Importe
                        FROM [1_stock] as Stk
                        INNER JOIN [3_devolucion_venta] AS d ON d.cod_pro_stock = stk.cod_pro_stock
                        WHERE d.cod_dev_vent = 4",codigo_devolucion )
           Select.fillTables(str)

     // devuelve un codigo a partir de un valor que se sabe no está repetido
    let selecCode (option : int, field : Object) =
        match option with
        | 8001 ->        // Devuelve el codigo de una provincia
            let provincia = field :?> string
            let str = String.Format("SELECT cod_provincia FROM [1_provincia] WHERE (nombre = '{0}')",provincia)
            Select.selectCod(str)
        
        | 8002 ->        // Devuelve el codigo de una ciudad
            let ciudad = field :?> string
            let str = String.Format("SELECT cod_ciu FROM [1_ciudad] WHERE (nombre = '{0}')",ciudad)
            Select.selectCod(str)
        
        | 8003 ->        // Devuelve el codigo de la direccion de un cliente
            let cod_cli = field :?> int
            let str  = String.Format("SELECT cod_dir FROM [3_cliente] WHERE cod_cli = {0}", cod_cli)
            Select.selectCod(str)
        
        | 8004 ->        // Devuelve el codigo de un pedido venta por el codigo de un remito
            let cod_rem = field :?> int
            let str  = String.Format("SELECT cod_ped_vent FROM [3_remito_venta] WHERE cod_rem_vent = {0}", cod_rem)
            Select.selectCod(str)
        
        | 8005->        // Devuelve el codigo de una cuenta corriente de cliente por un codigo de factura
            let cod_fac = field :?> int
            let str  = String.Format("SELECT ccc.cod_cta_cli
            FROM [3_cuenta_corriente_cliente] AS ccc
            INNER JOIN [3_cliente] AS C ON c.cod_cli = ccc.cod_cli
            INNER JOIN [3_pedido_venta] AS p ON p.cod_cli = c.cod_cli
            INNER JOIN [3_remito_venta] AS r ON r.cod_ped_vent = p.cod_ped_vent
            INNER JOIN [3_factura_venta] AS f ON f.cod_rem_vent = r.cod_rem_vent
            WHERE (f.cod_fac_vent = {0})", cod_fac)
            Select.selectCod(str)

        | 8006 ->        // Devuelve el codigo de una cuenta corriente de cliente por un codigo dde una nota de credito
            let cod_nc = field :?> int
            let str  = String.Format("SELECT ccc.cod_cta_cli
            FROM [3_cuenta_corriente_cliente] AS ccc
            INNER JOIN [3_cliente] AS C ON c.cod_cli = ccc.cod_cli
            INNER JOIN [3_pedido_venta] AS p ON p.cod_cli = c.cod_cli
            INNER JOIN [3_remito_venta] AS r ON r.cod_ped_vent = p.cod_ped_vent
            INNER JOIN [3_devolucion_venta] AS d ON d.cod_rem_vent = r.cod_rem_vent
            INNER JOIN [3_nota_credito_cliente] AS n ON n.cod_dev_vent = d.cod_dev_vent
            WHERE (n.cod_nc_vent = {0})", cod_nc)
            Select.selectCod(str)



     
// Consultas de eliminacion
module Delete =
    // Elimina por codigo
    let rec deleteFrom (option : int, codigo : int) =
        match option with      // 30000 Borra un cliente
        | 30001 ->
            deleteFrom(30002, codigo)
            deleteFrom(30003, codigo)
            let str = String.Format("DELETE FROM [3_cliente] WHERE (cod_cli = {0})",codigo)
            ExecuteCommands.execute(str)
            |> ignore

        | 30002 ->             // 30002 Apoya al delete 30000
            let str = String.Format("DELETE FROM [3_cuenta_corriente_cliente] WHERE (cod_cli = )",codigo)
            ExecuteCommands.execute str
            |> ignore
    
        | 30003 ->             // 30003 Apoya al delete 30000
            let str1 = String.Format("SELECT cod_dir FROM [3_cliente] WHERE (cod_cli = {0})",codigo)
            let cod_dir = Select.selectCod(str1)
            let str2 = String.Format("DELETE FROM [1_direccion] WHERE (cod )",codigo)
            ExecuteCommands.execute str2
            |>ignore

        | 30004 ->            // 30004 Borra un pedido de venta
            deleteFrom(30005, codigo)
            let str = String.Format("DELETE FROM [3_pedido_venta] WHERE (cod_ped_vent = {0})",codigo)
            ExecuteCommands.execute(str)
            |> ignore
        
        | 30005 ->            // 30005 apoya a 30004
            let str = String.Format("DELETE FROM [3_stock_venta] WHERE (cod_ped_vent = {0})",codigo)
            ExecuteCommands.execute(str)
            |> ignore

        | 30006 ->            // 30006 Borra una nota de credito
            let str = String.Format("DELETE FROM [3_nota_credito_cliente] WHERE (cod_nc_vent = {0})",codigo)
            ExecuteCommands.execute(str)
            |> ignore

        | 30007 ->             // Borra una devolucion.
            let str = String.Format("DELETE FROM [3_devolucion_venta] WHERE (cod_dev_vent = {0})",codigo)
            ExecuteCommands.execute(str)
            |> ignore
            
        | _ ->               //Patron no encontrado
            MessageBox.Show("El numero enviado como parametro no coincide con ningun patron de eliminacion") |> ignore
            |> ignore
    
    let DeleteFromTwoCodes(option : int, codigo : int[]) =
       match option with
        | 40006 ->           // 30007 borra un producto de pedido de venta
            let str = String.Format("DELETE FROM [3_stock_venta] WHERE (cod_pro_stock = {0}) AND (cod_ped_vent = {1})",codigo.[0],codigo.[1])
            ExecuteCommands.execute(str)
            |> ignore
        | _ ->               //Patron no encontrado
            MessageBox.Show("El numero enviado como parametro no coincide con ningun patron de eliminacion") |> ignore
            |> ignore


 
         