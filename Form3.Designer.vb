<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        Label1 = New Label()
        txt_nomeusuario = New TextBox()
        txt_telemovel = New TextBox()
        lbl_nomeUsuario = New Label()
        lbl_ntelemovel = New Label()
        txt_morada = New TextBox()
        txt_nome = New TextBox()
        lbl_morada = New Label()
        lbl_Nome = New Label()
        Label2 = New Label()
        txt_senhanovousuario = New TextBox()
        lbl_senhausuario = New Label()
        cmd_registar = New Button()
        btn_cancelarRegisto = New Button()
        cmd_sair = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonShadow
        Label1.Location = New Point(36, 139)
        Label1.Name = "Label1"
        Label1.Size = New Size(214, 36)
        Label1.TabIndex = 28
        Label1.Text = "Novo Cliente"
        ' 
        ' txt_nomeusuario
        ' 
        txt_nomeusuario.BackColor = Color.White
        txt_nomeusuario.Location = New Point(170, 367)
        txt_nomeusuario.Name = "txt_nomeusuario"
        txt_nomeusuario.Size = New Size(274, 27)
        txt_nomeusuario.TabIndex = 26
        ' 
        ' txt_telemovel
        ' 
        txt_telemovel.BackColor = Color.White
        txt_telemovel.Location = New Point(135, 225)
        txt_telemovel.Name = "txt_telemovel"
        txt_telemovel.Size = New Size(210, 27)
        txt_telemovel.TabIndex = 25
        ' 
        ' lbl_nomeUsuario
        ' 
        lbl_nomeUsuario.AutoSize = True
        lbl_nomeUsuario.Location = New Point(26, 370)
        lbl_nomeUsuario.Name = "lbl_nomeUsuario"
        lbl_nomeUsuario.Size = New Size(123, 20)
        lbl_nomeUsuario.TabIndex = 23
        lbl_nomeUsuario.Text = "Nome de usuário"
        ' 
        ' lbl_ntelemovel
        ' 
        lbl_ntelemovel.AutoSize = True
        lbl_ntelemovel.Location = New Point(31, 228)
        lbl_ntelemovel.Name = "lbl_ntelemovel"
        lbl_ntelemovel.Size = New Size(98, 20)
        lbl_ntelemovel.TabIndex = 22
        lbl_ntelemovel.Text = "Nº Telemóvel"
        ' 
        ' txt_morada
        ' 
        txt_morada.BackColor = Color.White
        txt_morada.Location = New Point(103, 261)
        txt_morada.Name = "txt_morada"
        txt_morada.Size = New Size(346, 27)
        txt_morada.TabIndex = 21
        ' 
        ' txt_nome
        ' 
        txt_nome.BackColor = Color.White
        txt_nome.Location = New Point(98, 192)
        txt_nome.Name = "txt_nome"
        txt_nome.Size = New Size(346, 27)
        txt_nome.TabIndex = 20
        ' 
        ' lbl_morada
        ' 
        lbl_morada.AutoSize = True
        lbl_morada.Location = New Point(31, 261)
        lbl_morada.Name = "lbl_morada"
        lbl_morada.Size = New Size(61, 20)
        lbl_morada.TabIndex = 19
        lbl_morada.Text = "Morada"
        ' 
        ' lbl_Nome
        ' 
        lbl_Nome.AutoSize = True
        lbl_Nome.Location = New Point(31, 195)
        lbl_Nome.Name = "lbl_Nome"
        lbl_Nome.Size = New Size(50, 20)
        lbl_Nome.TabIndex = 18
        lbl_Nome.Text = "Nome"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ButtonShadow
        Label2.Location = New Point(26, 309)
        Label2.Name = "Label2"
        Label2.Size = New Size(251, 36)
        Label2.TabIndex = 29
        Label2.Text = "Dados de Login"
        ' 
        ' txt_senhanovousuario
        ' 
        txt_senhanovousuario.BackColor = Color.White
        txt_senhanovousuario.Location = New Point(170, 410)
        txt_senhanovousuario.Name = "txt_senhanovousuario"
        txt_senhanovousuario.Size = New Size(274, 27)
        txt_senhanovousuario.TabIndex = 31
        ' 
        ' lbl_senhausuario
        ' 
        lbl_senhausuario.AutoSize = True
        lbl_senhausuario.Location = New Point(26, 413)
        lbl_senhausuario.Name = "lbl_senhausuario"
        lbl_senhausuario.Size = New Size(49, 20)
        lbl_senhausuario.TabIndex = 30
        lbl_senhausuario.Text = "Senha"
        ' 
        ' cmd_registar
        ' 
        cmd_registar.BackColor = Color.Black
        cmd_registar.ForeColor = Color.White
        cmd_registar.Location = New Point(135, 473)
        cmd_registar.Name = "cmd_registar"
        cmd_registar.Size = New Size(86, 43)
        cmd_registar.TabIndex = 32
        cmd_registar.Text = "Concluir"
        cmd_registar.UseVisualStyleBackColor = False
        ' 
        ' btn_cancelarRegisto
        ' 
        btn_cancelarRegisto.BackColor = Color.Black
        btn_cancelarRegisto.ForeColor = Color.White
        btn_cancelarRegisto.Location = New Point(263, 473)
        btn_cancelarRegisto.Name = "btn_cancelarRegisto"
        btn_cancelarRegisto.Size = New Size(89, 43)
        btn_cancelarRegisto.TabIndex = 33
        btn_cancelarRegisto.Text = "Cancelar"
        btn_cancelarRegisto.UseVisualStyleBackColor = False
        ' 
        ' cmd_sair
        ' 
        cmd_sair.BackColor = Color.Black
        cmd_sair.ForeColor = Color.White
        cmd_sair.Location = New Point(396, 473)
        cmd_sair.Name = "cmd_sair"
        cmd_sair.Size = New Size(92, 43)
        cmd_sair.TabIndex = 34
        cmd_sair.Text = "Sair"
        cmd_sair.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(517, 541)
        Controls.Add(cmd_sair)
        Controls.Add(btn_cancelarRegisto)
        Controls.Add(cmd_registar)
        Controls.Add(txt_senhanovousuario)
        Controls.Add(lbl_senhausuario)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_nomeusuario)
        Controls.Add(txt_telemovel)
        Controls.Add(lbl_nomeUsuario)
        Controls.Add(lbl_ntelemovel)
        Controls.Add(txt_morada)
        Controls.Add(txt_nome)
        Controls.Add(lbl_morada)
        Controls.Add(lbl_Nome)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nomeusuario As TextBox
    Friend WithEvents txt_telemovel As TextBox
    Friend WithEvents lbl_nomeUsuario As Label
    Friend WithEvents lbl_ntelemovel As Label
    Friend WithEvents txt_morada As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents lbl_morada As Label
    Friend WithEvents lbl_Nome As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_senhanovousuario As TextBox
    Friend WithEvents lbl_senhausuario As Label
    Friend WithEvents cmd_registar As Button
    Friend WithEvents btn_cancelarRegisto As Button
    Friend WithEvents cmd_sair As Button
End Class
