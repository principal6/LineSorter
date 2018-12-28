<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFrm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BTNSort = New System.Windows.Forms.Button()
        Me.RTBSearch = New System.Windows.Forms.RichTextBox()
        Me.LBTextLen = New System.Windows.Forms.Label()
        Me.BTNBroken = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTNSort
        '
        Me.BTNSort.Location = New System.Drawing.Point(12, 12)
        Me.BTNSort.Name = "BTNSort"
        Me.BTNSort.Size = New System.Drawing.Size(116, 22)
        Me.BTNSort.TabIndex = 4
        Me.BTNSort.Text = "줄 정리하기"
        Me.BTNSort.UseVisualStyleBackColor = True
        '
        'RTBSearch
        '
        Me.RTBSearch.Location = New System.Drawing.Point(12, 44)
        Me.RTBSearch.Name = "RTBSearch"
        Me.RTBSearch.Size = New System.Drawing.Size(516, 218)
        Me.RTBSearch.TabIndex = 6
        Me.RTBSearch.Text = ""
        '
        'LBTextLen
        '
        Me.LBTextLen.AutoSize = True
        Me.LBTextLen.Location = New System.Drawing.Point(146, 17)
        Me.LBTextLen.Name = "LBTextLen"
        Me.LBTextLen.Size = New System.Drawing.Size(42, 12)
        Me.LBTextLen.TabIndex = 7
        Me.LBTextLen.Text = "Label1"
        '
        'BTNBroken
        '
        Me.BTNBroken.Location = New System.Drawing.Point(342, 12)
        Me.BTNBroken.Name = "BTNBroken"
        Me.BTNBroken.Size = New System.Drawing.Size(186, 22)
        Me.BTNBroken.TabIndex = 8
        Me.BTNBroken.Text = "HTML 깨진 글씨 복구"
        Me.BTNBroken.UseVisualStyleBackColor = True
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 272)
        Me.Controls.Add(Me.BTNBroken)
        Me.Controls.Add(Me.LBTextLen)
        Me.Controls.Add(Me.RTBSearch)
        Me.Controls.Add(Me.BTNSort)
        Me.Name = "MainFrm"
        Me.Text = "줄 정리 및 HTML 깨진 글씨 복구"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNSort As Button
    Friend WithEvents RTBSearch As RichTextBox
    Friend WithEvents LBTextLen As Label
    Friend WithEvents BTNBroken As Button
End Class
