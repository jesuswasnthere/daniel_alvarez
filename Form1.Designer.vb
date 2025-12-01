<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    ' Formulario para el ejercicio 3.
    ' Autor: Daniel Alvarez, cédula 31812100

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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

    ' Controles del formulario
    Private WithEvents dgvNotas As System.Windows.Forms.DataGridView
    Private WithEvents btnCalcular As System.Windows.Forms.Button
    Private WithEvents btnLimpiar As System.Windows.Forms.Button
    Private txtResultados As System.Windows.Forms.TextBox
    Private lblInstrucciones As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgvNotas = New System.Windows.Forms.DataGridView()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtResultados = New System.Windows.Forms.TextBox()
        Me.lblInstrucciones = New System.Windows.Forms.Label()
        CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' lblInstrucciones
        '
        Me.lblInstrucciones.AutoSize = True
        Me.lblInstrucciones.Location = New System.Drawing.Point(12, 9)
        Me.lblInstrucciones.Name = "lblInstrucciones"
        Me.lblInstrucciones.Size = New System.Drawing.Size(380, 15)
        Me.lblInstrucciones.TabIndex = 0
        Me.lblInstrucciones.Text = "Ingrese las 4 notas (0..20) para cada uno de los 5 estudiantes y pulse Calcular"
        '
        ' dgvNotas
        '
        Me.dgvNotas.AllowUserToAddRows = False
        Me.dgvNotas.AllowUserToDeleteRows = False
        Me.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotas.Location = New System.Drawing.Point(12, 36)
        Me.dgvNotas.Name = "dgvNotas"
        Me.dgvNotas.RowHeadersVisible = False
        Me.dgvNotas.Size = New System.Drawing.Size(640, 180)
        Me.dgvNotas.TabIndex = 1
        '
        ' btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(12, 228)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(140, 30)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular promedios"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        ' btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(162, 228)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 30)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        ' txtResultados
        '
        Me.txtResultados.Location = New System.Drawing.Point(12, 270)
        Me.txtResultados.Multiline = True
        Me.txtResultados.Name = "txtResultados"
        Me.txtResultados.ReadOnly = True
        Me.txtResultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResultados.Size = New System.Drawing.Size(640, 180)
        Me.txtResultados.TabIndex = 4
        '
        ' Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 462)
        Me.Controls.Add(Me.txtResultados)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.dgvNotas)
        Me.Controls.Add(Me.lblInstrucciones)
        Me.Name = "Form1"
        Me.Text = "Promedios - Ejercicio 3"
        CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
