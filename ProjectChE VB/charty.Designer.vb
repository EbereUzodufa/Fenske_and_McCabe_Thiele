n_white">
	<summary>
  Looks up a localized resource of type System.Drawing.Bitmap.
</summary>
</member><member name="P:Alva_Reform_2.My.Resources.Resources.PreviewBitmap">
	<summary>
  Looks up a localized resource of type System.Drawing.Bitmap.
</summary>
</member><member name="P:Alva_Reform_2.My.Resources.Resources.purple_accent_4_50_">
	<summary>
  Looks up a localized resource of type System.Drawing.Bitmap.
</summary>
</member><member name="P:Alva_Reform_2.My.Resources.Resources.red">
	<summary>
  Looks up a localized resource of type System.Drawing.Bitmap.
</summary>
</member><member name="P:Alva_Reform_2.My.Resources.Resources.seminar_topic_Catalytic_Reduction_of_vehicular_emission_pollution__techinical_seminar">
	<summary>
  Looks up a localized resource of type System.Byte[].
</summary>
</member><member name="P:Alva_Reform_2.My.Resources.Resources.sky_blue">
	<summary>
  Looks up a localized resource of type System.Drawing.Bitmap.
</summary>
</member><member name="P:Alva_Reform_2.My.Resources.Resources.sweet_purple">
	<summary>
  Looks up a localized resource of type System.Drawing.Bitmap.
</summary>
</member><member name="P:Alva_Reform_2.My.Resources.Resources.Tan_dark_25_">
	<summary>
  Looks up a localized resource of type System.Drawing.Bitmap.
</summary>
</member><member name="P:Alva_Reform_2.My.Resources.Resources.whiteghost">
	<summary>
  Looks up a localized resource of type System.Drawing.Bitmap.
</summary>
</member><member name="P:Alva_Reform_2.My.Resources.Resources.yellow">
	<summary>
  Looks up a localized resource of type System.Drawing.Bitmap.
</summary>
</member><member name="T:Alva_Reform_2.My.Resources.Resources">
	<summary>
  A strongly-typed resource class, for looking up localized strings, etc.
</summary>
</member>
</members>
</doc>                                                                                                                                                                                                                     Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(12, 27)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(582, 395)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        '
        'charty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 487)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "charty"
        Me.Text = "charty"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
