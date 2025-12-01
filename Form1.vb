' Form1.vb
' Programa para el ejercicio 3: calcula promedio de 4 notas para 5 estudiantes
' Autor: Daniel Alvarez, cédula 31812100

Partial Public Class Form1

    Public Sub New()
        InitializeComponent()

        ' Inicializar la tabla de notas: 5 filas (estudiantes) y 4 columnas (notas)
        InitializeDataGridView()
    End Sub

    Private Sub InitializeDataGridView()
        dgvNotas.Columns.Clear()
        dgvNotas.Rows.Clear()

        ' Crear 4 columnas para las notas
        For i As Integer = 1 To 4
            Dim col As New DataGridViewTextBoxColumn()
            col.Name = $"Nota{i}"
            col.HeaderText = $"Nota {i}"
            col.Width = 120
            dgvNotas.Columns.Add(col)
        Next

        ' Crear 5 filas para los estudiantes
        For r As Integer = 1 To 5
            dgvNotas.Rows.Add()
            dgvNotas.Rows(r - 1).HeaderCell.Value = $"Est {r}"
        Next

        ' Ajustes menores
        dgvNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvNotas.AllowUserToAddRows = False
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Const PassingThreshold As Double = 10.0
        txtResultados.Clear()
        txtResultados.AppendText("Resultados del cálculo de promedios" & Environment.NewLine)
        txtResultados.AppendText("Nota: rango válido 0..20. Aprobación >= 10" & Environment.NewLine & Environment.NewLine)

        For r As Integer = 0 To dgvNotas.Rows.Count - 1
            Dim suma As Double = 0
            Dim validRow As Boolean = True

            For c As Integer = 0 To dgvNotas.Columns.Count - 1
                Dim cellValue = dgvNotas.Rows(r).Cells(c).Value
                Dim nota As Double

                If cellValue Is Nothing OrElse String.IsNullOrWhiteSpace(cellValue.ToString()) Then
                    MessageBox.Show($"Falta la nota {c + 1} del estudiante {r + 1}. Complete todos los campos.", "Datos incompletos",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    validRow = False
                    Exit For
                End If

                If Not Double.TryParse(cellValue.ToString(), nota) OrElse nota < 0 OrElse nota > 20 Then
                    MessageBox.Show($"La nota {c + 1} del estudiante {r + 1} no es válida. Ingrese un número entre 0 y 20.", "Dato inválido",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    validRow = False
                    Exit For
                End If

                suma += nota
            Next

            If Not validRow Then
                txtResultados.AppendText($"Estudiante {r + 1}: Datos inválidos - omitiendo cálculo." & Environment.NewLine)
                Continue For
            End If

            Dim promedio As Double = Math.Round(suma / dgvNotas.Columns.Count, 2)
            Dim estado As String = If(promedio >= PassingThreshold, "APROBADO", "REPROBADO")

            txtResultados.AppendText($"Estudiante {r + 1}: Promedio = {promedio} - {estado}" & Environment.NewLine)
        Next

        txtResultados.AppendText(Environment.NewLine & "Cálculo finalizado." & Environment.NewLine)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        InitializeDataGridView()
        txtResultados.Clear()
    End Sub

End Class
