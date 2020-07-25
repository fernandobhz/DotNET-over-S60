Imports System.Data

Public Class Form1

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Me.Close()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click

        Dim DR_TESTE As DataSet1.TB_TESTERow
        DR_TESTE = DataSet1.TB_TESTE.NewTB_TESTERow

        DR_TESTE.NM_TESTE = Now.ToString

        DataSet1.TB_TESTE.Rows.Add(DR_TESTE)
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Me.DataSet1.WriteXml("dataset1.xml")
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.DataSet1.Clear()
        Me.DataSet1.ReadXml("dataset1.xml")
    End Sub
End Class
