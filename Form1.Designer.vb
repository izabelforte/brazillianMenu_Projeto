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
        img_norte = New PictureBox()
        img_centrooeste = New PictureBox()
        img_sul = New PictureBox()
        img_nordeste = New PictureBox()
        img_sudeste = New PictureBox()
        img_acai = New PictureBox()
        img_brigadeiro = New PictureBox()
        cbb_comidas = New ComboBox()
        Label_inicio = New Label()
        cmd_inicio = New Button()
        Label2 = New Label()
        Label_norte = New Label()
        Label_sul = New Label()
        Label_centrooeste = New Label()
        Label_nordeste = New Label()
        Label_sudeste = New Label()
        Label_acai = New Label()
        Label_brigadeiro = New Label()
        cmd_finalizar = New Button()
        Label1 = New Label()
        txt_quantidadecomida = New TextBox()
        lbl_bebidas = New Label()
        cbb_bebidas = New ComboBox()
        btn_nao = New Button()
        Btn_sim = New Button()
        Label4 = New Label()
        txt_quantidadebebida = New TextBox()
        lbl_sumo = New Label()
        lbl_icetea = New Label()
        lbl_agua = New Label()
        lbl_guarana = New Label()
        lbl_cocacola = New Label()
        img_sumo = New PictureBox()
        img_icetea = New PictureBox()
        img_agua = New PictureBox()
        img_guarana = New PictureBox()
        img_coca = New PictureBox()
        btn_sair = New Button()
        txt_totalpedido = New TextBox()
        txt_valorpato = New TextBox()
        txt_valorarrozpequi = New TextBox()
        txt_valorarrozcarreteiro = New TextBox()
        txt_valorbaiao = New TextBox()
        txt_valorbrigadeiro = New TextBox()
        txt_valoracai = New TextBox()
        txt_valorfeijoada = New TextBox()
        txt_totalcomidas = New TextBox()
        txt_totalbebidas = New TextBox()
        btn_calcularcomida = New Button()
        btn_calcularbebida = New Button()
        txt_valorcoca = New TextBox()
        txt_valorsumo = New TextBox()
        txt_valorguarana = New TextBox()
        txt_valoricetea = New TextBox()
        txt_valoragua = New TextBox()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        btn_trocarusuario = New Button()
        CType(img_norte, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_centrooeste, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_sul, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_nordeste, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_sudeste, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_acai, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_brigadeiro, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_sumo, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_icetea, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_agua, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_guarana, ComponentModel.ISupportInitialize).BeginInit()
        CType(img_coca, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' img_norte
        ' 
        img_norte.Image = CType(resources.GetObject("img_norte.Image"), Image)
        img_norte.Location = New Point(467, 147)
        img_norte.Name = "img_norte"
        img_norte.Size = New Size(149, 151)
        img_norte.SizeMode = PictureBoxSizeMode.StretchImage
        img_norte.TabIndex = 0
        img_norte.TabStop = False
        img_norte.Visible = False
        ' 
        ' img_centrooeste
        ' 
        img_centrooeste.Image = CType(resources.GetObject("img_centrooeste.Image"), Image)
        img_centrooeste.Location = New Point(467, 147)
        img_centrooeste.Name = "img_centrooeste"
        img_centrooeste.Size = New Size(164, 151)
        img_centrooeste.SizeMode = PictureBoxSizeMode.StretchImage
        img_centrooeste.TabIndex = 1
        img_centrooeste.TabStop = False
        img_centrooeste.Visible = False
        ' 
        ' img_sul
        ' 
        img_sul.Image = CType(resources.GetObject("img_sul.Image"), Image)
        img_sul.Location = New Point(467, 147)
        img_sul.Name = "img_sul"
        img_sul.Size = New Size(164, 151)
        img_sul.SizeMode = PictureBoxSizeMode.StretchImage
        img_sul.TabIndex = 2
        img_sul.TabStop = False
        img_sul.Visible = False
        ' 
        ' img_nordeste
        ' 
        img_nordeste.Image = CType(resources.GetObject("img_nordeste.Image"), Image)
        img_nordeste.Location = New Point(467, 147)
        img_nordeste.Name = "img_nordeste"
        img_nordeste.Size = New Size(164, 151)
        img_nordeste.SizeMode = PictureBoxSizeMode.StretchImage
        img_nordeste.TabIndex = 3
        img_nordeste.TabStop = False
        img_nordeste.Visible = False
        ' 
        ' img_sudeste
        ' 
        img_sudeste.Image = CType(resources.GetObject("img_sudeste.Image"), Image)
        img_sudeste.Location = New Point(467, 147)
        img_sudeste.Name = "img_sudeste"
        img_sudeste.Size = New Size(164, 151)
        img_sudeste.SizeMode = PictureBoxSizeMode.StretchImage
        img_sudeste.TabIndex = 4
        img_sudeste.TabStop = False
        img_sudeste.Visible = False
        ' 
        ' img_acai
        ' 
        img_acai.Image = CType(resources.GetObject("img_acai.Image"), Image)
        img_acai.Location = New Point(467, 147)
        img_acai.Name = "img_acai"
        img_acai.Size = New Size(164, 151)
        img_acai.SizeMode = PictureBoxSizeMode.StretchImage
        img_acai.TabIndex = 5
        img_acai.TabStop = False
        img_acai.Visible = False
        ' 
        ' img_brigadeiro
        ' 
        img_brigadeiro.Image = CType(resources.GetObject("img_brigadeiro.Image"), Image)
        img_brigadeiro.Location = New Point(467, 147)
        img_brigadeiro.Name = "img_brigadeiro"
        img_brigadeiro.Size = New Size(164, 151)
        img_brigadeiro.SizeMode = PictureBoxSizeMode.StretchImage
        img_brigadeiro.TabIndex = 6
        img_brigadeiro.TabStop = False
        img_brigadeiro.Visible = False
        ' 
        ' cbb_comidas
        ' 
        cbb_comidas.BackColor = Color.Black
        cbb_comidas.Font = New Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cbb_comidas.ForeColor = Color.White
        cbb_comidas.FormattingEnabled = True
        cbb_comidas.Items.AddRange(New Object() {"Norte", "Sul", "Centro-oeste", "Nordeste", "Sudeste", "Sobremesa: Açaí", "Sobremesa: Brigadeiro"})
        cbb_comidas.Location = New Point(35, 200)
        cbb_comidas.Name = "cbb_comidas"
        cbb_comidas.Size = New Size(174, 27)
        cbb_comidas.TabIndex = 9
        cbb_comidas.Text = "Selecione a região"
        cbb_comidas.Visible = False
        ' 
        ' Label_inicio
        ' 
        Label_inicio.AutoSize = True
        Label_inicio.BackColor = Color.Transparent
        Label_inicio.Font = New Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label_inicio.Location = New Point(357, 230)
        Label_inicio.Name = "Label_inicio"
        Label_inicio.Size = New Size(229, 31)
        Label_inicio.TabIndex = 10
        Label_inicio.Text = "Seja bem-vindo!"
        ' 
        ' cmd_inicio
        ' 
        cmd_inicio.BackColor = Color.Black
        cmd_inicio.ForeColor = Color.White
        cmd_inicio.Location = New Point(400, 277)
        cmd_inicio.Name = "cmd_inicio"
        cmd_inicio.Size = New Size(147, 43)
        cmd_inicio.TabIndex = 11
        cmd_inicio.Text = "Faça seu pedido aqui"
        cmd_inicio.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(12, 586)
        Label2.Name = "Label2"
        Label2.Size = New Size(392, 32)
        Label2.TabIndex = 12
        Label2.Text = "Seu restaurante tradicional brasileiro que não te deixa sentir " & vbCrLf & "saudade da culinária regional."
        ' 
        ' Label_norte
        ' 
        Label_norte.AutoSize = True
        Label_norte.BackColor = Color.Transparent
        Label_norte.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label_norte.ForeColor = SystemColors.ActiveBorder
        Label_norte.Location = New Point(390, 301)
        Label_norte.Name = "Label_norte"
        Label_norte.Size = New Size(207, 37)
        Label_norte.TabIndex = 13
        Label_norte.Text = "Pato no Tucupi"
        Label_norte.Visible = False
        ' 
        ' Label_sul
        ' 
        Label_sul.AutoSize = True
        Label_sul.BackColor = Color.Transparent
        Label_sul.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label_sul.ForeColor = SystemColors.ActiveBorder
        Label_sul.Location = New Point(384, 303)
        Label_sul.Name = "Label_sul"
        Label_sul.Size = New Size(233, 37)
        Label_sul.TabIndex = 14
        Label_sul.Text = "Arroz Carreteiro "
        Label_sul.Visible = False
        ' 
        ' Label_centrooeste
        ' 
        Label_centrooeste.AutoSize = True
        Label_centrooeste.BackColor = Color.Transparent
        Label_centrooeste.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label_centrooeste.ForeColor = SystemColors.ActiveBorder
        Label_centrooeste.Location = New Point(441, 307)
        Label_centrooeste.Name = "Label_centrooeste"
        Label_centrooeste.Size = New Size(151, 31)
        Label_centrooeste.TabIndex = 15
        Label_centrooeste.Text = "Arroz Pequi  "
        Label_centrooeste.Visible = False
        ' 
        ' Label_nordeste
        ' 
        Label_nordeste.AutoSize = True
        Label_nordeste.BackColor = Color.Transparent
        Label_nordeste.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label_nordeste.ForeColor = SystemColors.ActiveBorder
        Label_nordeste.Location = New Point(400, 307)
        Label_nordeste.Name = "Label_nordeste"
        Label_nordeste.Size = New Size(189, 37)
        Label_nordeste.TabIndex = 16
        Label_nordeste.Text = "Baião de dois"
        Label_nordeste.Visible = False
        ' 
        ' Label_sudeste
        ' 
        Label_sudeste.AutoSize = True
        Label_sudeste.BackColor = Color.Transparent
        Label_sudeste.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label_sudeste.ForeColor = SystemColors.ButtonShadow
        Label_sudeste.Location = New Point(466, 307)
        Label_sudeste.Name = "Label_sudeste"
        Label_sudeste.Size = New Size(133, 37)
        Label_sudeste.TabIndex = 17
        Label_sudeste.Text = "Feijoada "
        Label_sudeste.Visible = False
        ' 
        ' Label_acai
        ' 
        Label_acai.AutoSize = True
        Label_acai.BackColor = Color.Transparent
        Label_acai.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_acai.ForeColor = SystemColors.ActiveBorder
        Label_acai.Location = New Point(516, 311)
        Label_acai.Name = "Label_acai"
        Label_acai.Size = New Size(70, 32)
        Label_acai.TabIndex = 18
        Label_acai.Text = "Açaí "
        Label_acai.Visible = False
        ' 
        ' Label_brigadeiro
        ' 
        Label_brigadeiro.AutoSize = True
        Label_brigadeiro.BackColor = Color.Transparent
        Label_brigadeiro.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label_brigadeiro.ForeColor = SystemColors.ActiveBorder
        Label_brigadeiro.Location = New Point(463, 307)
        Label_brigadeiro.Name = "Label_brigadeiro"
        Label_brigadeiro.Size = New Size(134, 32)
        Label_brigadeiro.TabIndex = 19
        Label_brigadeiro.Text = "Brigadeiro"
        Label_brigadeiro.Visible = False
        ' 
        ' cmd_finalizar
        ' 
        cmd_finalizar.BackColor = Color.Black
        cmd_finalizar.ForeColor = Color.White
        cmd_finalizar.Location = New Point(467, 574)
        cmd_finalizar.Name = "cmd_finalizar"
        cmd_finalizar.Size = New Size(171, 45)
        cmd_finalizar.TabIndex = 21
        cmd_finalizar.Text = "Finalizar Pedido"
        cmd_finalizar.UseVisualStyleBackColor = False
        cmd_finalizar.UseWaitCursor = True
        cmd_finalizar.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(58, 200)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 22
        Label1.Visible = False
        ' 
        ' txt_quantidadecomida
        ' 
        txt_quantidadecomida.Location = New Point(265, 186)
        txt_quantidadecomida.Multiline = True
        txt_quantidadecomida.Name = "txt_quantidadecomida"
        txt_quantidadecomida.Size = New Size(92, 54)
        txt_quantidadecomida.TabIndex = 23
        txt_quantidadecomida.Visible = False
        ' 
        ' lbl_bebidas
        ' 
        lbl_bebidas.AutoSize = True
        lbl_bebidas.BackColor = SystemColors.ActiveCaptionText
        lbl_bebidas.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_bebidas.ForeColor = SystemColors.ButtonFace
        lbl_bebidas.Location = New Point(26, 314)
        lbl_bebidas.Name = "lbl_bebidas"
        lbl_bebidas.Size = New Size(271, 31)
        lbl_bebidas.TabIndex = 35
        lbl_bebidas.Text = "Deseja adicionar bebida?"
        lbl_bebidas.Visible = False
        ' 
        ' cbb_bebidas
        ' 
        cbb_bebidas.BackColor = Color.Black
        cbb_bebidas.Font = New Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        cbb_bebidas.ForeColor = Color.White
        cbb_bebidas.FormattingEnabled = True
        cbb_bebidas.Items.AddRange(New Object() {"Coca-cola", "Guaraná", "Icetea", "Sumo de Laranja", "Água"})
        cbb_bebidas.Location = New Point(35, 460)
        cbb_bebidas.Name = "cbb_bebidas"
        cbb_bebidas.Size = New Size(174, 27)
        cbb_bebidas.TabIndex = 34
        cbb_bebidas.Text = "Selecione a bebida"
        cbb_bebidas.Visible = False
        ' 
        ' btn_nao
        ' 
        btn_nao.BackgroundImage = CType(resources.GetObject("btn_nao.BackgroundImage"), Image)
        btn_nao.BackgroundImageLayout = ImageLayout.Stretch
        btn_nao.Location = New Point(163, 370)
        btn_nao.Name = "btn_nao"
        btn_nao.Size = New Size(60, 43)
        btn_nao.TabIndex = 33
        btn_nao.UseVisualStyleBackColor = True
        btn_nao.Visible = False
        ' 
        ' Btn_sim
        ' 
        Btn_sim.BackgroundImage = CType(resources.GetObject("Btn_sim.BackgroundImage"), Image)
        Btn_sim.BackgroundImageLayout = ImageLayout.Stretch
        Btn_sim.Location = New Point(59, 370)
        Btn_sim.Name = "Btn_sim"
        Btn_sim.Size = New Size(60, 43)
        Btn_sim.TabIndex = 32
        Btn_sim.UseVisualStyleBackColor = True
        Btn_sim.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(150, 434)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 23)
        Label4.TabIndex = 31
        Label4.Visible = False
        ' 
        ' txt_quantidadebebida
        ' 
        txt_quantidadebebida.Location = New Point(265, 416)
        txt_quantidadebebida.Multiline = True
        txt_quantidadebebida.Name = "txt_quantidadebebida"
        txt_quantidadebebida.Size = New Size(93, 50)
        txt_quantidadebebida.TabIndex = 36
        txt_quantidadebebida.Visible = False
        ' 
        ' lbl_sumo
        ' 
        lbl_sumo.AutoSize = True
        lbl_sumo.BackColor = Color.Transparent
        lbl_sumo.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_sumo.ForeColor = SystemColors.ActiveBorder
        lbl_sumo.Location = New Point(430, 532)
        lbl_sumo.Name = "lbl_sumo"
        lbl_sumo.Size = New Size(187, 31)
        lbl_sumo.TabIndex = 51
        lbl_sumo.Text = "Sumo de laranja"
        lbl_sumo.Visible = False
        ' 
        ' lbl_icetea
        ' 
        lbl_icetea.AutoSize = True
        lbl_icetea.BackColor = Color.Transparent
        lbl_icetea.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_icetea.ForeColor = SystemColors.ActiveBorder
        lbl_icetea.Location = New Point(539, 534)
        lbl_icetea.Name = "lbl_icetea"
        lbl_icetea.Size = New Size(77, 31)
        lbl_icetea.TabIndex = 50
        lbl_icetea.Text = "Icetea"
        lbl_icetea.Visible = False
        ' 
        ' lbl_agua
        ' 
        lbl_agua.AutoSize = True
        lbl_agua.BackColor = Color.Transparent
        lbl_agua.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_agua.ForeColor = SystemColors.ActiveBorder
        lbl_agua.Location = New Point(539, 534)
        lbl_agua.Name = "lbl_agua"
        lbl_agua.Size = New Size(70, 31)
        lbl_agua.TabIndex = 49
        lbl_agua.Text = "Água"
        lbl_agua.Visible = False
        ' 
        ' lbl_guarana
        ' 
        lbl_guarana.AutoSize = True
        lbl_guarana.BackColor = Color.Transparent
        lbl_guarana.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_guarana.ForeColor = SystemColors.ActiveBorder
        lbl_guarana.Location = New Point(513, 534)
        lbl_guarana.Name = "lbl_guarana"
        lbl_guarana.Size = New Size(103, 31)
        lbl_guarana.TabIndex = 48
        lbl_guarana.Text = "Guaraná"
        lbl_guarana.Visible = False
        ' 
        ' lbl_cocacola
        ' 
        lbl_cocacola.AutoSize = True
        lbl_cocacola.BackColor = Color.Transparent
        lbl_cocacola.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_cocacola.ForeColor = SystemColors.ActiveBorder
        lbl_cocacola.Location = New Point(463, 528)
        lbl_cocacola.Name = "lbl_cocacola"
        lbl_cocacola.Size = New Size(118, 31)
        lbl_cocacola.TabIndex = 47
        lbl_cocacola.Text = "Coca-cola"
        lbl_cocacola.Visible = False
        ' 
        ' img_sumo
        ' 
        img_sumo.BackgroundImage = CType(resources.GetObject("img_sumo.BackgroundImage"), Image)
        img_sumo.BackgroundImageLayout = ImageLayout.Stretch
        img_sumo.Location = New Point(485, 378)
        img_sumo.Name = "img_sumo"
        img_sumo.Size = New Size(131, 141)
        img_sumo.TabIndex = 46
        img_sumo.TabStop = False
        img_sumo.Visible = False
        ' 
        ' img_icetea
        ' 
        img_icetea.BackgroundImage = CType(resources.GetObject("img_icetea.BackgroundImage"), Image)
        img_icetea.BackgroundImageLayout = ImageLayout.Stretch
        img_icetea.Location = New Point(485, 378)
        img_icetea.Name = "img_icetea"
        img_icetea.Size = New Size(131, 141)
        img_icetea.TabIndex = 45
        img_icetea.TabStop = False
        img_icetea.Visible = False
        ' 
        ' img_agua
        ' 
        img_agua.BackgroundImage = CType(resources.GetObject("img_agua.BackgroundImage"), Image)
        img_agua.BackgroundImageLayout = ImageLayout.Stretch
        img_agua.Location = New Point(485, 378)
        img_agua.Name = "img_agua"
        img_agua.Size = New Size(131, 141)
        img_agua.TabIndex = 44
        img_agua.TabStop = False
        img_agua.Visible = False
        ' 
        ' img_guarana
        ' 
        img_guarana.BackgroundImage = CType(resources.GetObject("img_guarana.BackgroundImage"), Image)
        img_guarana.BackgroundImageLayout = ImageLayout.Stretch
        img_guarana.Location = New Point(485, 378)
        img_guarana.Name = "img_guarana"
        img_guarana.Size = New Size(131, 141)
        img_guarana.TabIndex = 43
        img_guarana.TabStop = False
        img_guarana.Visible = False
        ' 
        ' img_coca
        ' 
        img_coca.BackgroundImage = CType(resources.GetObject("img_coca.BackgroundImage"), Image)
        img_coca.BackgroundImageLayout = ImageLayout.Stretch
        img_coca.Location = New Point(485, 378)
        img_coca.Name = "img_coca"
        img_coca.Size = New Size(131, 141)
        img_coca.TabIndex = 42
        img_coca.TabStop = False
        img_coca.Visible = False
        ' 
        ' btn_sair
        ' 
        btn_sair.BackColor = Color.Black
        btn_sair.ForeColor = Color.White
        btn_sair.Location = New Point(854, 602)
        btn_sair.Name = "btn_sair"
        btn_sair.Size = New Size(82, 37)
        btn_sair.TabIndex = 52
        btn_sair.Text = "Sair"
        btn_sair.UseVisualStyleBackColor = False
        btn_sair.UseWaitCursor = True
        ' 
        ' txt_totalpedido
        ' 
        txt_totalpedido.Location = New Point(644, 574)
        txt_totalpedido.Multiline = True
        txt_totalpedido.Name = "txt_totalpedido"
        txt_totalpedido.Size = New Size(186, 45)
        txt_totalpedido.TabIndex = 53
        txt_totalpedido.Text = "Valor total do pedido"
        txt_totalpedido.Visible = False
        ' 
        ' txt_valorpato
        ' 
        txt_valorpato.Location = New Point(623, 313)
        txt_valorpato.Name = "txt_valorpato"
        txt_valorpato.Size = New Size(65, 27)
        txt_valorpato.TabIndex = 54
        txt_valorpato.Text = "12"
        txt_valorpato.Visible = False
        ' 
        ' txt_valorarrozpequi
        ' 
        txt_valorarrozpequi.Location = New Point(623, 314)
        txt_valorarrozpequi.Name = "txt_valorarrozpequi"
        txt_valorarrozpequi.Size = New Size(65, 27)
        txt_valorarrozpequi.TabIndex = 55
        txt_valorarrozpequi.Text = "9,90"
        txt_valorarrozpequi.Visible = False
        ' 
        ' txt_valorarrozcarreteiro
        ' 
        txt_valorarrozcarreteiro.Location = New Point(623, 313)
        txt_valorarrozcarreteiro.Name = "txt_valorarrozcarreteiro"
        txt_valorarrozcarreteiro.Size = New Size(65, 27)
        txt_valorarrozcarreteiro.TabIndex = 56
        txt_valorarrozcarreteiro.Text = "10"
        txt_valorarrozcarreteiro.Visible = False
        ' 
        ' txt_valorbaiao
        ' 
        txt_valorbaiao.Location = New Point(623, 314)
        txt_valorbaiao.Name = "txt_valorbaiao"
        txt_valorbaiao.Size = New Size(65, 27)
        txt_valorbaiao.TabIndex = 57
        txt_valorbaiao.Text = "10"
        txt_valorbaiao.Visible = False
        ' 
        ' txt_valorbrigadeiro
        ' 
        txt_valorbrigadeiro.Location = New Point(623, 313)
        txt_valorbrigadeiro.Name = "txt_valorbrigadeiro"
        txt_valorbrigadeiro.Size = New Size(65, 27)
        txt_valorbrigadeiro.TabIndex = 58
        txt_valorbrigadeiro.Text = "2"
        txt_valorbrigadeiro.Visible = False
        ' 
        ' txt_valoracai
        ' 
        txt_valoracai.Location = New Point(623, 313)
        txt_valoracai.Name = "txt_valoracai"
        txt_valoracai.Size = New Size(65, 27)
        txt_valoracai.TabIndex = 59
        txt_valoracai.Text = "8"
        txt_valoracai.Visible = False
        ' 
        ' txt_valorfeijoada
        ' 
        txt_valorfeijoada.Location = New Point(623, 314)
        txt_valorfeijoada.Name = "txt_valorfeijoada"
        txt_valorfeijoada.Size = New Size(65, 27)
        txt_valorfeijoada.TabIndex = 60
        txt_valorfeijoada.Text = "11"
        txt_valorfeijoada.Visible = False
        ' 
        ' txt_totalcomidas
        ' 
        txt_totalcomidas.Location = New Point(677, 186)
        txt_totalcomidas.Multiline = True
        txt_totalcomidas.Name = "txt_totalcomidas"
        txt_totalcomidas.Size = New Size(132, 41)
        txt_totalcomidas.TabIndex = 61
        txt_totalcomidas.Visible = False
        ' 
        ' txt_totalbebidas
        ' 
        txt_totalbebidas.Location = New Point(677, 416)
        txt_totalbebidas.Multiline = True
        txt_totalbebidas.Name = "txt_totalbebidas"
        txt_totalbebidas.Size = New Size(132, 41)
        txt_totalbebidas.TabIndex = 62
        txt_totalbebidas.Visible = False
        ' 
        ' btn_calcularcomida
        ' 
        btn_calcularcomida.BackColor = Color.Black
        btn_calcularcomida.ForeColor = Color.White
        btn_calcularcomida.Location = New Point(363, 188)
        btn_calcularcomida.Name = "btn_calcularcomida"
        btn_calcularcomida.Size = New Size(41, 39)
        btn_calcularcomida.TabIndex = 63
        btn_calcularcomida.Text = "x"
        btn_calcularcomida.UseVisualStyleBackColor = False
        btn_calcularcomida.UseWaitCursor = True
        btn_calcularcomida.Visible = False
        ' 
        ' btn_calcularbebida
        ' 
        btn_calcularbebida.BackColor = Color.Black
        btn_calcularbebida.ForeColor = Color.White
        btn_calcularbebida.Location = New Point(363, 416)
        btn_calcularbebida.Name = "btn_calcularbebida"
        btn_calcularbebida.Size = New Size(41, 39)
        btn_calcularbebida.TabIndex = 64
        btn_calcularbebida.Text = "x"
        btn_calcularbebida.UseVisualStyleBackColor = False
        btn_calcularbebida.UseWaitCursor = True
        btn_calcularbebida.Visible = False
        ' 
        ' txt_valorcoca
        ' 
        txt_valorcoca.Location = New Point(623, 532)
        txt_valorcoca.Name = "txt_valorcoca"
        txt_valorcoca.Size = New Size(65, 27)
        txt_valorcoca.TabIndex = 65
        txt_valorcoca.Text = "2,5"
        txt_valorcoca.Visible = False
        ' 
        ' txt_valorsumo
        ' 
        txt_valorsumo.Location = New Point(623, 534)
        txt_valorsumo.Name = "txt_valorsumo"
        txt_valorsumo.Size = New Size(65, 27)
        txt_valorsumo.TabIndex = 66
        txt_valorsumo.Text = "1,8"
        txt_valorsumo.Visible = False
        ' 
        ' txt_valorguarana
        ' 
        txt_valorguarana.Location = New Point(623, 532)
        txt_valorguarana.Name = "txt_valorguarana"
        txt_valorguarana.Size = New Size(65, 27)
        txt_valorguarana.TabIndex = 67
        txt_valorguarana.Text = "2,5"
        txt_valorguarana.Visible = False
        ' 
        ' txt_valoricetea
        ' 
        txt_valoricetea.Location = New Point(622, 534)
        txt_valoricetea.Name = "txt_valoricetea"
        txt_valoricetea.Size = New Size(65, 27)
        txt_valoricetea.TabIndex = 68
        txt_valoricetea.Text = "2"
        txt_valoricetea.Visible = False
        ' 
        ' txt_valoragua
        ' 
        txt_valoragua.Location = New Point(622, 534)
        txt_valoragua.Name = "txt_valoragua"
        txt_valoragua.Size = New Size(65, 27)
        txt_valoragua.TabIndex = 69
        txt_valoragua.Text = "1"
        txt_valoragua.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ActiveCaptionText
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(253, 387)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 28)
        Label3.TabIndex = 70
        Label3.Text = "Quantidade"
        Label3.Visible = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ActiveCaptionText
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(253, 155)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 28)
        Label5.TabIndex = 71
        Label5.Text = "Quantidade"
        Label5.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ActiveCaptionText
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(677, 385)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 28)
        Label6.TabIndex = 72
        Label6.Text = "Total Bebidas"
        Label6.Visible = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ActiveCaptionText
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ButtonFace
        Label8.Location = New Point(677, 155)
        Label8.Name = "Label8"
        Label8.Size = New Size(135, 28)
        Label8.TabIndex = 74
        Label8.Text = "Total Comidas"
        Label8.Visible = False
        ' 
        ' btn_trocarusuario
        ' 
        btn_trocarusuario.BackColor = Color.Black
        btn_trocarusuario.ForeColor = Color.White
        btn_trocarusuario.Location = New Point(814, 24)
        btn_trocarusuario.Name = "btn_trocarusuario"
        btn_trocarusuario.Size = New Size(122, 45)
        btn_trocarusuario.TabIndex = 75
        btn_trocarusuario.Text = "Trocar usuário"
        btn_trocarusuario.UseVisualStyleBackColor = False
        btn_trocarusuario.UseWaitCursor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(956, 670)
        Controls.Add(btn_trocarusuario)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(txt_valoragua)
        Controls.Add(txt_valoricetea)
        Controls.Add(txt_valorguarana)
        Controls.Add(txt_valorsumo)
        Controls.Add(txt_valorcoca)
        Controls.Add(btn_calcularbebida)
        Controls.Add(btn_calcularcomida)
        Controls.Add(txt_totalbebidas)
        Controls.Add(txt_totalcomidas)
        Controls.Add(txt_valorfeijoada)
        Controls.Add(txt_valoracai)
        Controls.Add(txt_valorbrigadeiro)
        Controls.Add(txt_valorbaiao)
        Controls.Add(txt_valorarrozcarreteiro)
        Controls.Add(txt_valorarrozpequi)
        Controls.Add(txt_valorpato)
        Controls.Add(txt_totalpedido)
        Controls.Add(btn_sair)
        Controls.Add(lbl_sumo)
        Controls.Add(lbl_icetea)
        Controls.Add(lbl_agua)
        Controls.Add(lbl_guarana)
        Controls.Add(lbl_cocacola)
        Controls.Add(img_sumo)
        Controls.Add(img_icetea)
        Controls.Add(img_agua)
        Controls.Add(img_guarana)
        Controls.Add(img_coca)
        Controls.Add(txt_quantidadebebida)
        Controls.Add(lbl_bebidas)
        Controls.Add(cbb_bebidas)
        Controls.Add(btn_nao)
        Controls.Add(Btn_sim)
        Controls.Add(Label4)
        Controls.Add(txt_quantidadecomida)
        Controls.Add(Label1)
        Controls.Add(cmd_finalizar)
        Controls.Add(Label_brigadeiro)
        Controls.Add(Label_acai)
        Controls.Add(Label_sudeste)
        Controls.Add(Label_nordeste)
        Controls.Add(Label_centrooeste)
        Controls.Add(Label_sul)
        Controls.Add(Label_norte)
        Controls.Add(Label2)
        Controls.Add(cmd_inicio)
        Controls.Add(Label_inicio)
        Controls.Add(cbb_comidas)
        Controls.Add(img_brigadeiro)
        Controls.Add(img_acai)
        Controls.Add(img_sudeste)
        Controls.Add(img_nordeste)
        Controls.Add(img_sul)
        Controls.Add(img_centrooeste)
        Controls.Add(img_norte)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "BrazilianMenu"
        CType(img_norte, ComponentModel.ISupportInitialize).EndInit()
        CType(img_centrooeste, ComponentModel.ISupportInitialize).EndInit()
        CType(img_sul, ComponentModel.ISupportInitialize).EndInit()
        CType(img_nordeste, ComponentModel.ISupportInitialize).EndInit()
        CType(img_sudeste, ComponentModel.ISupportInitialize).EndInit()
        CType(img_acai, ComponentModel.ISupportInitialize).EndInit()
        CType(img_brigadeiro, ComponentModel.ISupportInitialize).EndInit()
        CType(img_sumo, ComponentModel.ISupportInitialize).EndInit()
        CType(img_icetea, ComponentModel.ISupportInitialize).EndInit()
        CType(img_agua, ComponentModel.ISupportInitialize).EndInit()
        CType(img_guarana, ComponentModel.ISupportInitialize).EndInit()
        CType(img_coca, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents img_norte As PictureBox
    Friend WithEvents img_centrooeste As PictureBox
    Friend WithEvents img_sul As PictureBox
    Friend WithEvents img_nordeste As PictureBox
    Friend WithEvents img_sudeste As PictureBox
    Friend WithEvents img_acai As PictureBox
    Friend WithEvents img_brigadeiro As PictureBox
    Friend WithEvents cbb_comidas As ComboBox
    Friend WithEvents Label_inicio As Label
    Friend WithEvents cmd_inicio As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_norte As Label
    Friend WithEvents Label_sul As Label
    Friend WithEvents Label_centrooeste As Label
    Friend WithEvents Label_nordeste As Label
    Friend WithEvents Label_sudeste As Label
    Friend WithEvents Label_acai As Label
    Friend WithEvents Label_brigadeiro As Label
    Friend WithEvents cmd_finalizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_quantidadecomida As TextBox
    Friend WithEvents lbl_bebidas As Label
    Friend WithEvents cbb_bebidas As ComboBox
    Friend WithEvents btn_nao As Button
    Friend WithEvents Btn_sim As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_quantidadebebida As TextBox
    Friend WithEvents lbl_sumo As Label
    Friend WithEvents lbl_icetea As Label
    Friend WithEvents lbl_agua As Label
    Friend WithEvents lbl_guarana As Label
    Friend WithEvents lbl_cocacola As Label
    Friend WithEvents img_sumo As PictureBox
    Friend WithEvents img_icetea As PictureBox
    Friend WithEvents img_agua As PictureBox
    Friend WithEvents img_guarana As PictureBox
    Friend WithEvents img_coca As PictureBox
    Friend WithEvents btn_sair As Button
    Friend WithEvents txt_totalpedido As TextBox
    Friend WithEvents txt_valorpato As TextBox
    Friend WithEvents txt_valorarrozpequi As TextBox
    Friend WithEvents txt_valorarrozcarreteiro As TextBox
    Friend WithEvents txt_valorbaiao As TextBox
    Friend WithEvents txt_valorbrigadeiro As TextBox
    Friend WithEvents txt_valoracai As TextBox
    Friend WithEvents txt_valorfeijoada As TextBox
    Friend WithEvents txt_totalcomidas As TextBox
    Friend WithEvents txt_totalbebidas As TextBox
    Friend WithEvents btn_calcularcomida As Button
    Friend WithEvents btn_calcularbebida As Button
    Friend WithEvents txt_valorcoca As TextBox
    Friend WithEvents txt_valorsumo As TextBox
    Friend WithEvents txt_valorguarana As TextBox
    Friend WithEvents txt_valoricetea As TextBox
    Friend WithEvents txt_valoragua As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_trocarusuario As Button
End Class
