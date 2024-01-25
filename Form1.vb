Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1


    Private Sub cmd_inicio_Click(sender As Object, e As EventArgs) Handles cmd_inicio.Click
        cbb_comidas.Show()
        Label2.Hide()
        Label_inicio.Hide()
        lbl_bebidas.Show()
        btn_sair.Show()
        btn_nao.Show()
        Btn_sim.Show()
        txt_quantidadecomida.Show()
        cmd_inicio.Hide()
        btn_calcularcomida.Show()
        txt_totalcomidas.Show()
        cmd_finalizar.Show()
        txt_totalpedido.Show()
        Label5.Show()
        Label8.Show()


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_comidas.SelectedIndexChanged
        If cbb_comidas.SelectedIndex = 0 Then
            img_norte.Show()
            Label_norte.Show()
            txt_valorpato.Show()
            Label_centrooeste.Hide()
            Label_sudeste.Hide()
            Label_sul.Hide()
            Label_nordeste.Hide()
            img_sul.Hide()
            img_nordeste.Hide()
            img_sudeste.Hide()
            img_centrooeste.Hide()
            img_acai.Hide()
            img_brigadeiro.Hide()
            Label_acai.Hide()
            Label_brigadeiro.Hide()
            txt_valorarrozcarreteiro.Hide()
            txt_valorarrozpequi.Hide()
            txt_valorbaiao.Hide()
            txt_valorbrigadeiro.Hide()
            txt_valorfeijoada.Hide()
            txt_valoracai.Hide()

        End If
        If cbb_comidas.SelectedIndex = 1 Then
            img_norte.Hide()
            txt_valorpato.Hide()
            txt_valorarrozpequi.Hide()
            txt_valorbaiao.Hide()
            txt_valorbrigadeiro.Hide()
            txt_valorfeijoada.Hide()
            txt_valoracai.Hide()
            Label_sul.Show()
            Label_norte.Hide()
            Label_centrooeste.Hide()
            Label_sudeste.Hide()
            Label_nordeste.Hide()
            img_sul.Show()
            txt_valorarrozcarreteiro.Show()
            img_nordeste.Hide()
            img_sudeste.Hide()
            img_centrooeste.Hide()
            img_acai.Hide()
            img_brigadeiro.Hide()
            Label_acai.Hide()
            Label_brigadeiro.Hide()
        End If
        If cbb_comidas.SelectedIndex = 2 Then
            txt_valorarrozcarreteiro.Hide()
            txt_valorpato.Hide()
            txt_valorbaiao.Hide()
            txt_valorbrigadeiro.Hide()
            txt_valorfeijoada.Hide()
            txt_valoracai.Hide()
            img_norte.Hide()
            Label_centrooeste.Show()
            txt_valorarrozpequi.Show()
            Label_norte.Hide()
            Label_sudeste.Hide()
            Label_sul.Hide()
            Label_nordeste.Hide()
            img_sul.Hide()
            img_nordeste.Hide()
            img_sudeste.Hide()
            img_centrooeste.Show()
            img_acai.Hide()
            img_brigadeiro.Hide()
            Label_acai.Hide()
            Label_brigadeiro.Hide()
        End If
        If cbb_comidas.SelectedIndex = 3 Then
            txt_valorarrozcarreteiro.Hide()
            txt_valorpato.Hide()
            txt_valorarrozpequi.Hide()
            txt_valorbrigadeiro.Hide()
            txt_valorfeijoada.Hide()
            txt_valoracai.Hide()
            txt_valorarrozpequi.Hide()
            img_norte.Hide()
            Label_nordeste.Show()
            txt_valorbaiao.Show()
            Label_norte.Hide()
            Label_centrooeste.Hide()
            Label_sudeste.Hide()
            Label_sul.Hide()
            img_sul.Hide()
            img_nordeste.Show()
            img_sudeste.Hide()
            img_centrooeste.Hide()
            img_acai.Hide()
            img_brigadeiro.Hide()
            Label_acai.Hide()
            Label_brigadeiro.Hide()
        End If
        If cbb_comidas.SelectedIndex = 4 Then
            img_norte.Hide()
            Label_sudeste.Show()
            txt_valorfeijoada.Show()
            txt_valorpato.Hide()
            txt_valorbaiao.Hide()
            txt_valorbrigadeiro.Hide()
            txt_valoracai.Hide()
            txt_valorarrozpequi.Hide()
            Label_norte.Hide()
            Label_centrooeste.Hide()
            Label_sul.Hide()
            Label_nordeste.Hide()
            img_sul.Hide()
            img_nordeste.Hide()
            img_sudeste.Show()
            img_centrooeste.Hide()
            img_acai.Hide()
            img_brigadeiro.Hide()
            Label_acai.Hide()
            Label_brigadeiro.Hide()

        End If
        If cbb_comidas.SelectedIndex = 5 Then
            img_norte.Hide()
            Label_acai.Show()
            Label_brigadeiro.Hide()
            Label_sudeste.Hide()
            Label_norte.Hide()
            Label_centrooeste.Hide()
            Label_sul.Hide()
            Label_nordeste.Hide()
            txt_valorpato.Hide()
            txt_valorarrozpequi.Hide()
            txt_valorbaiao.Hide()
            txt_valorbrigadeiro.Hide()
            txt_valorfeijoada.Hide()
            txt_valoracai.Show()
            img_sul.Hide()
            img_nordeste.Hide()
            img_sudeste.Hide()
            img_centrooeste.Hide()
            txt_valoracai.Show()
            img_acai.Show()
            img_brigadeiro.Hide()
        End If
        If cbb_comidas.SelectedIndex = 6 Then
            img_norte.Hide()
            Label_acai.Hide()
            Label_brigadeiro.Show()
            Label_sudeste.Hide()
            Label_norte.Hide()
            Label_centrooeste.Hide()
            Label_sul.Hide()
            Label_nordeste.Hide()
            txt_valorpato.Hide()
            txt_valorbaiao.Hide()
            txt_valorfeijoada.Hide()
            txt_valoracai.Hide()
            img_sul.Hide()
            img_nordeste.Hide()
            img_sudeste.Hide()
            img_centrooeste.Hide()
            txt_valoracai.Hide()
            txt_valorbrigadeiro.Show()
            txt_valorarrozpequi.Hide()
            img_acai.Hide()
            img_brigadeiro.Show()
        End If
        If cbb_comidas.SelectedIndex >= 0 Then
            cmd_inicio.Hide()
        End If
        If cbb_comidas.SelectedIndex >= 0 Then
            cmd_finalizar.Show()
        End If
    End Sub
    Private Sub Btn_sim_Click(sender As Object, e As EventArgs) Handles Btn_sim.Click
        cbb_bebidas.Show()
        txt_quantidadebebida.Show()
        txt_totalbebidas.Show()
        btn_calcularbebida.Show()
        Label3.Show()
        Label6.Show()

    End Sub
    Private Sub cmb_bebidas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_bebidas.SelectedIndexChanged
        If cbb_bebidas.SelectedIndex = 0 Then
            img_coca.Show()
            lbl_cocacola.Show()
            txt_valorcoca.Show()
            img_guarana.Hide()
            lbl_guarana.Hide()
            img_icetea.Hide()
            lbl_icetea.Hide()
            img_sumo.Hide()
            lbl_sumo.Hide()
            img_agua.Hide()
            lbl_agua.Hide()
            txt_valoricetea.Hide()
            txt_valorguarana.Hide()
            txt_valorsumo.Hide()
            txt_valoragua.Hide()
        End If
        If cbb_bebidas.SelectedIndex = 1 Then
            img_coca.Hide()
            lbl_cocacola.Hide()
            img_guarana.Show()
            lbl_guarana.Show()
            txt_valorguarana.Show()
            img_icetea.Hide()
            lbl_icetea.Hide()
            img_sumo.Hide()
            lbl_sumo.Hide()
            img_agua.Hide()
            lbl_agua.Hide()
            txt_valoricetea.Hide()
            txt_valorsumo.Hide()
            txt_valoragua.Hide()
            txt_valorcoca.Hide()
        End If
        If cbb_bebidas.SelectedIndex = 2 Then
            img_coca.Hide()
            lbl_cocacola.Hide()
            img_guarana.Hide()
            lbl_guarana.Hide()
            img_icetea.Show()
            lbl_icetea.Show()
            txt_valoricetea.Show()
            img_sumo.Hide()
            lbl_sumo.Hide()
            img_agua.Hide()
            lbl_agua.Hide()
            txt_valorguarana.Hide()
            txt_valorsumo.Hide()
            txt_valoragua.Hide()
            txt_valorcoca.Hide()
        End If
        If cbb_bebidas.SelectedIndex = 3 Then
            img_coca.Hide()
            lbl_cocacola.Hide()
            img_guarana.Hide()
            lbl_guarana.Hide()
            img_icetea.Hide()
            lbl_icetea.Hide()
            txt_valoricetea.Hide()
            img_sumo.Show()
            txt_valorsumo.Show()
            txt_valorguarana.Hide()
            txt_valoragua.Hide()
            txt_valorcoca.Hide()
            lbl_sumo.Show()
            img_agua.Hide()
            lbl_agua.Hide()
        End If
        If cbb_bebidas.SelectedIndex = 4 Then
            img_coca.Hide()
            lbl_cocacola.Hide()
            img_guarana.Hide()
            lbl_guarana.Hide()
            img_icetea.Hide()
            lbl_icetea.Hide()
            img_sumo.Hide()
            lbl_sumo.Hide()
            img_agua.Show()
            txt_valoragua.Show()
            txt_valoricetea.Hide()
            txt_valorguarana.Hide()
            txt_valorsumo.Hide()
            txt_valorcoca.Hide()
            lbl_agua.Show()
        End If
    End Sub


    Private Sub cmd_finalizar_Click(sender As Object, e As EventArgs) Handles cmd_finalizar.Click
        Dim valor1 As Double
        Dim valor2 As Double


        If Double.TryParse(txt_totalcomidas.Text, valor1) AndAlso Double.TryParse(txt_totalbebidas.Text, valor2) Then

            Dim resultado As Double = valor1 + valor2

            txt_totalpedido.Text = resultado.ToString()
        Else

            txt_totalpedido.Text = "Erro"
        End If

    End Sub



    Private Sub txt_total_TextChanged(sender As Object, e As EventArgs) Handles txt_totalpedido.TextChanged

    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        End
    End Sub

    Private Sub txt_totalcomidas_TextChanged(sender As Object, e As EventArgs) Handles txt_totalcomidas.TextChanged


    End Sub

    Private Sub btn_calcularcomida_Click(sender As Object, e As EventArgs) Handles btn_calcularcomida.Click
        Dim valor1 As Double
        Dim valor2 As Double
        ' região norte
        If cbb_comidas.SelectedIndex = 0 Then
            If Double.TryParse(txt_quantidadecomida.Text, valor1) AndAlso Double.TryParse(txt_valorpato.Text, valor2) Then

                Dim resultado As Double = valor1 * valor2

                txt_totalcomidas.Text = resultado.ToString()
            Else

                txt_totalcomidas.Text = "Erro"
            End If
        End If
        'região sul
        If cbb_comidas.SelectedIndex = 1 Then
            If Double.TryParse(txt_quantidadecomida.Text, valor1) AndAlso Double.TryParse(txt_valorarrozcarreteiro.Text, valor2) Then

                Dim resultado As Double = valor1 * valor2

                txt_totalcomidas.Text = resultado.ToString()
            Else

                txt_totalcomidas.Text = "Erro"
            End If
        End If
        'regiao centro-oeste

        If cbb_comidas.SelectedIndex = 2 Then
            If Double.TryParse(txt_quantidadecomida.Text, valor1) AndAlso Double.TryParse(txt_valorarrozpequi.Text, valor2) Then

                Dim resultado As Double = valor1 * valor2

                txt_totalcomidas.Text = resultado.ToString()
            Else

                txt_totalcomidas.Text = "Erro"
            End If
        End If
        'regiao nordeste
        If cbb_comidas.SelectedIndex = 3 Then
            If Double.TryParse(txt_quantidadecomida.Text, valor1) AndAlso Double.TryParse(txt_valorbaiao.Text, valor2) Then

                Dim resultado As Double = valor1 * valor2

                txt_totalcomidas.Text = resultado.ToString()
            Else

                txt_totalcomidas.Text = "Erro"
            End If
        End If
        'regiao sudeste
        If cbb_comidas.SelectedIndex = 4 Then
            If Double.TryParse(txt_quantidadecomida.Text, valor1) AndAlso Double.TryParse(txt_valorfeijoada.Text, valor2) Then

                Dim resultado As Double = valor1 * valor2

                txt_totalcomidas.Text = resultado.ToString()
            Else

                txt_totalcomidas.Text = "Erro"
            End If
        End If
        'acai
        If cbb_comidas.SelectedIndex = 5 Then
            If Double.TryParse(txt_quantidadecomida.Text, valor1) AndAlso Double.TryParse(txt_valoracai.Text, valor2) Then

                Dim resultado As Double = valor1 * valor2

                txt_totalcomidas.Text = resultado.ToString()
            Else

                txt_totalcomidas.Text = "Erro"
            End If
        End If
        'brigadeiro
        If cbb_comidas.SelectedIndex = 6 Then
            If Double.TryParse(txt_quantidadecomida.Text, valor1) AndAlso Double.TryParse(txt_valorbrigadeiro.Text, valor2) Then

                Dim resultado As Double = valor1 * valor2

                txt_totalcomidas.Text = resultado.ToString()
            Else

                txt_totalcomidas.Text = "Erro"
            End If
        End If
    End Sub

    Private Sub btn_calcularbebida_Click(sender As Object, e As EventArgs) Handles btn_calcularbebida.Click
        Dim valor1 As Double
        Dim valor2 As Double
        ' Coca-cola
        If cbb_bebidas.SelectedIndex = 0 Then
            If Double.TryParse(txt_quantidadebebida.Text, valor1) AndAlso Double.TryParse(txt_valorcoca.Text, valor2) Then

                Dim resultado As Double = valor1 * valor2

                txt_totalbebidas.Text = resultado.ToString()
            Else

                txt_totalbebidas.Text = "Erro"
            End If
        End If
        'guarana
        If cbb_bebidas.SelectedIndex = 1 Then
            If Double.TryParse(txt_quantidadebebida.Text, valor1) AndAlso Double.TryParse(txt_valorguarana.Text, valor2) Then

                Dim resultado As Double = valor1 * valor2

                txt_totalbebidas.Text = resultado.ToString()
            Else

                txt_totalbebidas.Text = "Erro"
            End If
        End If
        'icetea
        If cbb_bebidas.SelectedIndex = 2 Then
            If Double.TryParse(txt_quantidadebebida.Text, valor1) AndAlso Double.TryParse(txt_valoricetea.Text, valor2) Then

                Dim resultado As Double = valor1 * valor2

                txt_totalbebidas.Text = resultado.ToString()
            Else

                txt_totalbebidas.Text = "Erro"
            End If
        End If
        'sumo de laranja
        If cbb_bebidas.SelectedIndex = 3 Then
            If Double.TryParse(txt_quantidadebebida.Text, valor1) AndAlso Double.TryParse(txt_valorsumo.Text, valor2) Then

                Dim resultado As Double = valor1 * valor2

                txt_totalbebidas.Text = resultado.ToString()
            Else

                txt_totalbebidas.Text = "Erro"
            End If
        End If
        'agua
        If cbb_bebidas.SelectedIndex = 4 Then
            If Double.TryParse(txt_quantidadebebida.Text, valor1) AndAlso Double.TryParse(txt_valoragua.Text, valor2) Then

                Dim resultado As Double = valor1 * valor2

                txt_totalbebidas.Text = resultado.ToString()
            Else

                txt_totalbebidas.Text = "Erro"
            End If
        End If
    End Sub

    Private Sub btn_nao_Click(sender As Object, e As EventArgs) Handles btn_nao.Click

        txt_quantidadebebida.Show()
        txt_totalbebidas.Show()
        btn_calcularbebida.Show()
        Label3.Show()
        Label6.Show()
    End Sub

    Private Sub btn_trocarusuario_Click(sender As Object, e As EventArgs) Handles btn_trocarusuario.Click
        Me.Hide()
        LoginForm1.Show()

    End Sub
End Class
