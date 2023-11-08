<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="Proyecto1ProgramacionII.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="main.css" rel="stylesheet" />
    <title>Calculadora</title>
</head>

<body>
    <header>
        <!--Titulo de la página-->
        <h1>Calculadora</h1>
    </header>
    <form id="form1" runat="server">
        <div>
            <!--Establcecimiento de interfaz de botones acomodados por divisiones que forman una matriz de 4 x 6-->
            <asp:Button ID="ButtonReset" runat="server" Text="Reiniciar calculadora" Width ="200px" Height="50px" BackColor="Red" OnClick="ButtonReset_Click" />
        </div>
        <div></div>
        <br />
        <br />
        <br />
        <div id=" RellenoIzquierdo1">
            <!--Instrucciones para seleccionar la posición en la que se escriben los numeros con los botones-->
            <p>Seleccione la posición en la que quiere digitar el numero</p>
           
        </div>
        <div id="CalcRow1">
            <!--Botones del 7 al 9-->
            <asp:Button ID="Button7" runat="server" Text="    7    " style="border-spacing:2px" Height="43px" OnClick="Button7_Click" />
            <asp:Button ID="Button8" runat="server" Text="    8    " Height="43px" OnClick="Button8_Click" />
            <asp:Button ID="Button9" runat="server" Text="    9    " Height="43px" OnClick="Button9_Click" />
        </div>
        <div id="OpColumnNoUsar">
            <!--Titulo operación-->
            <h4>Operación</h4>
        </div>
        <div id="RellenoDerecho1">
            <!--Titulo del resultado-->
            <h4>Resultado</h4>
        </div>        
        <div id=" RellenoIzquierdo2">
            <!--DrompDownList para seleccionar si se quiere escribir en la textbox del numero 1 o el numero 2-->
            <asp:DropDownList ID="DropDownList1" runat="server" Height="26px" Width="198px">
                <asp:ListItem>Numero 1</asp:ListItem>
                <asp:ListItem>Numero 2</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div id="CalcRow2">
            <!--Botones del 4 al 6-->
            <asp:Button ID="Button4" runat="server" Text="    4    " style="border-spacing:2px" Height="43px" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" Text="    5    " Height="43px" OnClick="Button5_Click" />
            <asp:Button ID="Button6" runat="server" Text="    6    " Height="43px" OnClick="Button6_Click" />
        </div>
        <div id="OpColumn">
            <!--Label y textbox para el numero 1-->
            <asp:label ID="label1" runat="server" Text="Numero 1: " />
            <asp:TextBox ID="TextBoxN1" runat="server" Width="201px"></asp:TextBox>
        </div>
        <div id="RellenoDerecho2">

            </div>        
        <div id=" RellenoIzquierdo3">

            <p>Seleccione la opreación que desea realizar</p></div>
        <div id="CalcRow3">
            <!--Botones del 1 al 3-->
            <asp:Button ID="Button1" runat="server" Text="    1    " style="border-spacing:2px" Height="43px" OnClick="Button1_Click1"/>
            <asp:Button ID="Button2" runat="server" Text="    2    " Height="43px" OnClick="Button2_Click"/>
            <asp:Button ID="Button3" runat="server" Text="    3    " Height="43px" OnClick="Button3_Click"/>
        </div>
        <div id="OpColumnNoUsar3">
            <br />
        </div>
        <div id="RellenoDerecho4">
            <!--T+itulo del resultado-->
            <p>Resultado</p>
        </div>
        <div id=" RellenoIzquierdo4">
            <!--DropDownList para seleccionar la operación que queremos-->
            <asp:DropDownList ID="DropDownList2" runat="server" Height="23px" Width="194px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem>Suma</asp:ListItem>
                <asp:ListItem>Resta</asp:ListItem>
                <asp:ListItem>Multiplicacion</asp:ListItem>
                <asp:ListItem>Division</asp:ListItem>
                <asp:ListItem>Factorial</asp:ListItem>
                <asp:ListItem>Raiz cuadrada</asp:ListItem>
                <asp:ListItem>Logaritmo natural</asp:ListItem>
                <asp:ListItem>Potencia</asp:ListItem>
                <asp:ListItem>10 a la potencia</asp:ListItem>
                <asp:ListItem>Numero al cuadrado</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div id="CalcRow4">
            <!--Botones Clear, 0, coma(,) y = -->
            <asp:Button ID="ButtonC" runat="server" Text="   C    " Height="43px" OnClick="ButtonC_Click" BackColor="Red" BorderColor="Black"/>
            <asp:Button ID="Button0" runat="server" Text="    0    " Height="43px" OnClick="Button0_Click"/>
            <asp:Button ID="ButtonComa" runat="server" Text="    ,    " Height="43px" OnClick="ButtonComa_Click"/>
            <asp:Button ID="ButtonEquals" runat="server" Text="   =    " Height="43px" OnClick="ButtonEquals_Click" BackColor="#99FF99" BorderColor="Black"/>
        </div>
        <div id="OpColumnNoUsar2">

        </div>
        <div id="RellenoDerecho3">
            <!--TextBoc donde se imprime el resultado de la operacion-->
            <asp:TextBox ID="TextBoxResultado" runat="server" Height="30px" Width="203px" ReadOnly="True"></asp:TextBox>
        </div>
        <div> 
            <!--Botón para actualizar la pagina y que se apliquen los cambios respectivos-->
            <asp:Button ID="Button10" runat="server" Text="Aplicar formula" />
        </div>
        <div></div>
        <div>
            <!--Label y textBox para el numero 2-->
            <asp:label ID="labelN2" runat="server" Text="Numero 2: " />
            <asp:TextBox ID="TextBoxN2" runat="server" Width="204px"></asp:TextBox>
        </div>
        <div></div>
        <article></article>
        <footer>
            <!--Pie de página-->
            <p>Página hecha por: <br />
            Minor Josué Porras Varela<br />
            Carlos Roberto Solano Ruiz<br />
            Ashley Francheska Calero Gaitan
            </p>
        </footer>
    </form>
</body>

</html>
