<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim CD_TESTEDataGridColumnStyleDataGridTextBoxColumn As System.Windows.Forms.DataGridTextBoxColumn
        Dim NM_TESTEDataGridColumnStyleDataGridTextBoxColumn As System.Windows.Forms.DataGridTextBoxColumn
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.DataSet1 = New SmartDeviceProject7.DataSet1
        Me.TB_TESTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_TESTEDataGrid = New System.Windows.Forms.DataGrid
        Me.TB_TESTETableStyleDataGridTableStyle = New System.Windows.Forms.DataGridTableStyle
        CD_TESTEDataGridColumnStyleDataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn
        NM_TESTEDataGridColumnStyleDataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_TESTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CD_TESTEDataGridColumnStyleDataGridTextBoxColumn
        '
        CD_TESTEDataGridColumnStyleDataGridTextBoxColumn.Format = ""
        CD_TESTEDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = Nothing
        CD_TESTEDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Código"
        CD_TESTEDataGridColumnStyleDataGridTextBoxColumn.MappingName = "CD_TESTE"
        '
        'NM_TESTEDataGridColumnStyleDataGridTextBoxColumn
        '
        NM_TESTEDataGridColumnStyleDataGridTextBoxColumn.Format = ""
        NM_TESTEDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = Nothing
        NM_TESTEDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Nome"
        NM_TESTEDataGridColumnStyleDataGridTextBoxColumn.MappingName = "NM_TESTE"
        NM_TESTEDataGridColumnStyleDataGridTextBoxColumn.Width = 150
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem4)
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "Sair"
        '
        'MenuItem4
        '
        Me.MenuItem4.MenuItems.Add(Me.MenuItem5)
        Me.MenuItem4.MenuItems.Add(Me.MenuItem3)
        Me.MenuItem4.MenuItems.Add(Me.MenuItem2)
        Me.MenuItem4.Text = "Dados"
        '
        'MenuItem5
        '
        Me.MenuItem5.Text = "Novo"
        '
        'MenuItem3
        '
        Me.MenuItem3.Text = "Salvar"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "Consultar"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.Prefix = ""
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TB_TESTEBindingSource
        '
        Me.TB_TESTEBindingSource.DataMember = "TB_TESTE"
        Me.TB_TESTEBindingSource.DataSource = Me.DataSet1
        '
        'TB_TESTEDataGrid
        '
        Me.TB_TESTEDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TB_TESTEDataGrid.DataSource = Me.TB_TESTEBindingSource
        Me.TB_TESTEDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TB_TESTEDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.TB_TESTEDataGrid.Name = "TB_TESTEDataGrid"
        Me.TB_TESTEDataGrid.Size = New System.Drawing.Size(240, 266)
        Me.TB_TESTEDataGrid.TabIndex = 0
        Me.TB_TESTEDataGrid.TableStyles.Add(Me.TB_TESTETableStyleDataGridTableStyle)
        '
        'TB_TESTETableStyleDataGridTableStyle
        '
        Me.TB_TESTETableStyleDataGridTableStyle.GridColumnStyles.Add(CD_TESTEDataGridColumnStyleDataGridTextBoxColumn)
        Me.TB_TESTETableStyleDataGridTableStyle.GridColumnStyles.Add(NM_TESTEDataGridColumnStyleDataGridTextBoxColumn)
        Me.TB_TESTETableStyleDataGridTableStyle.MappingName = "TB_TESTE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(131.0!, 131.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 266)
        Me.Controls.Add(Me.TB_TESTEDataGrid)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = ".NET over S60"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_TESTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents DataSet1 As SmartDeviceProject7.DataSet1
    Friend WithEvents TB_TESTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_TESTEDataGrid As System.Windows.Forms.DataGrid
    Friend WithEvents TB_TESTETableStyleDataGridTableStyle As System.Windows.Forms.DataGridTableStyle

End Class
