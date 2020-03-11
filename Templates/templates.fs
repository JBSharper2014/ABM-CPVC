namespace Templates

open System.Windows.Forms
open System.Data.SqlClient
open System.Data
open System
open CapaDatos


(*
module Parse =
    let stringToDouble (str : string) =
        double(str)
    let stringToInt (str : string) = 
        int32(str)
 *)

module Connection =
    let connection = 
        CapaDatos.Conexion.ConexionDB()
        

module ExecuteCommands =
    let execute (commandString : string)  =
        let command = new SqlCommand(commandString, Connection.connection)
        try
        Connection.connection.Open()
        let execute = command.ExecuteNonQuery()
        Connection.connection.Close()
        CapaDatos.MessageException.message <- ""
        with _ as ex -> CapaDatos.MessageException.message <- ex.Message
        Connection.connection.Close()
    execute 
    |> ignore
    

module Select =
    let selectCod (commandString : string) =
        let command = new SqlCommand(commandString, Connection.connection )
        try
        Connection.connection.Open()
        let execute = 
            use reader = command.ExecuteReader()
            if reader.Read() then(reader.GetInt32(0)) 
            else 0
        Connection.connection.Close()
        CapaDatos.MessageException.message <- ""
        execute 
        with _ as ex -> 
            CapaDatos.MessageException.message <- ex.Message
            Connection.connection.Close()
            -1

    

    let selectExist (commandString : string) =
        let command = new SqlCommand(commandString, Connection.connection )
        try
        Connection.connection.Open()
        let execute = 
            use reader = command.ExecuteReader()
            if reader.Read() then
                true
            else 
                false                 
        Connection.connection.Close()
        CapaDatos.MessageException.message <- ""
        execute
        with _ as ex -> 
        CapaDatos.MessageException.message <- ex.Message
        Connection.connection.Close()
        false
        

    let trueOrFalse (commandString : string) =
        let command = new SqlCommand(commandString, Connection.connection )
        try
        Connection.connection.Open()
        let execute = 
            use reader = command.ExecuteReader()
            if reader.Read() then(reader.GetBoolean(0)) 
            else false
        Connection.connection.Close()
        CapaDatos.MessageException.message <- ""
        execute
        with _ as ex -> 
        CapaDatos.MessageException.message <- ex.Message
        Connection.connection.Close()
        false

    let returnString (commandString : string) =
        let command = new SqlCommand(commandString, Connection.connection )
        try
        Connection.connection.Open()
        let execute = 
            use reader = command.ExecuteReader()
            if reader.Read() then(reader.GetString(0)) 
            else ""
        Connection.connection.Close()
        CapaDatos.MessageException.message <- ""
        execute
        with _ as ex -> 
            CapaDatos.MessageException.message <- ex.Message
            Connection.connection.Close()
            "error"

    let fillTables (commandString : string) =
        let adapter = new SqlDataAdapter(commandString, Connection.connection )
        let table = new DataTable()
        try
        let execute = 
            adapter.Fill(table)
        Connection.connection.Close()
        CapaDatos.MessageException.message <- ""
        table
        with _ as ex -> 
        CapaDatos.MessageException.message <- ex.Message
        Connection.connection.Close()
        table
    


// module Messages =
//     let allowedInsert =  MessageBox.Show("Insertado con exito") |> ignore
//     let deniedInsert = MessageBox.Show("La insercion fue fallida") |> ignore 
//     let allowedConsult = MessageBox.Show("Exito en la consulta") |> ignore
//     let deniedConsult = MessageBox.Show("La consulta fue fallida") |>ignore