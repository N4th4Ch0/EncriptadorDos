<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Label1 = New Label()
        lblsin = New Label()
        lblEncriptado = New Label()
        Label4 = New Label()
        txtSinEncriptar = New TextBox()
        txtEncriptado = New TextBox()
        txtResultado = New TextBox()
        btnEncriptar = New Button()
        btnDesencriptar = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.InactiveCaptionText
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(716, 100)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Lime
        Label1.Location = New Point(11, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(224, 25)
        Label1.TabIndex = 0
        Label1.Text = "Encriptador de palabras"' 
        ' lblsin
        ' 
        lblsin.AutoSize = True
        lblsin.BackColor = SystemColors.ActiveCaptionText
        lblsin.Font = New Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblsin.ForeColor = Color.Lime
        lblsin.Location = New Point(11, 121)
        lblsin.Name = "lblsin"
        lblsin.Size = New Size(180, 22)
        lblsin.TabIndex = 1
        lblsin.Text = "Texto a encriptar"' 
        ' lblEncriptado
        ' 
        lblEncriptado.AutoSize = True
        lblEncriptado.BackColor = SystemColors.ActiveCaptionText
        lblEncriptado.Font = New Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblEncriptado.ForeColor = Color.Lime
        lblEncriptado.Location = New Point(11, 164)
        lblEncriptado.Name = "lblEncriptado"
        lblEncriptado.Size = New Size(170, 22)
        lblEncriptado.TabIndex = 2
        lblEncriptado.Text = "Texto encriptado"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ActiveCaptionText
        Label4.Font = New Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Lime
        Label4.Location = New Point(11, 362)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 22)
        Label4.TabIndex = 3
        Label4.Text = "Resultado"' 
        ' txtSinEncriptar
        ' 
        txtSinEncriptar.BackColor = SystemColors.MenuText
        txtSinEncriptar.ForeColor = Color.Snow
        txtSinEncriptar.Location = New Point(196, 121)
        txtSinEncriptar.Name = "txtSinEncriptar"
        txtSinEncriptar.Size = New Size(348, 23)
        txtSinEncriptar.TabIndex = 4
        ' 
        ' txtEncriptado
        ' 
        txtEncriptado.BackColor = SystemColors.MenuText
        txtEncriptado.ForeColor = Color.Red
        txtEncriptado.Location = New Point(197, 164)
        txtEncriptado.Multiline = True
        txtEncriptado.Name = "txtEncriptado"
        txtEncriptado.Size = New Size(348, 146)
        txtEncriptado.TabIndex = 5
        ' 
        ' txtResultado
        ' 
        txtResultado.BackColor = SystemColors.MenuText
        txtResultado.ForeColor = Color.Lime
        txtResultado.Location = New Point(196, 364)
        txtResultado.Name = "txtResultado"
        txtResultado.Size = New Size(348, 23)
        txtResultado.TabIndex = 6
        ' 
        ' btnEncriptar
        ' 
        btnEncriptar.BackColor = SystemColors.ActiveCaptionText
        btnEncriptar.Font = New Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnEncriptar.ForeColor = Color.Red
        btnEncriptar.Location = New Point(196, 441)
        btnEncriptar.Name = "btnEncriptar"
        btnEncriptar.Size = New Size(110, 42)
        btnEncriptar.TabIndex = 7
        btnEncriptar.Text = "Encriptador"
        btnEncriptar.UseVisualStyleBackColor = False
        ' 
        ' btnDesencriptar
        ' 
        btnDesencriptar.BackColor = SystemColors.ActiveCaptionText
        btnDesencriptar.Font = New Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnDesencriptar.ForeColor = Color.Lime
        btnDesencriptar.Location = New Point(312, 441)
        btnDesencriptar.Name = "btnDesencriptar"
        btnDesencriptar.Size = New Size(116, 42)
        btnDesencriptar.TabIndex = 8
        btnDesencriptar.Text = "Desencriptar"
        btnDesencriptar.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.Font = New Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Red
        Button1.Location = New Point(472, 441)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 42)
        Button1.TabIndex = 9
        Button1.Text = "Encriptador"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaptionText
        Button2.Font = New Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.Lime
        Button2.Location = New Point(588, 441)
        Button2.Name = "Button2"
        Button2.Size = New Size(116, 42)
        Button2.TabIndex = 10
        Button2.Text = "Desencriptar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(716, 513)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btnDesencriptar)
        Controls.Add(btnEncriptar)
        Controls.Add(txtResultado)
        Controls.Add(txtEncriptado)
        Controls.Add(txtSinEncriptar)
        Controls.Add(Label4)
        Controls.Add(lblEncriptado)
        Controls.Add(lblsin)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblsin As Label
    Friend WithEvents lblEncriptado As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSinEncriptar As TextBox
    Friend WithEvents txtEncriptado As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnEncriptar As Button
    Friend WithEvents btnDesencriptar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
