   M S B A M L   `   `   `  ����C  ?Customer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Customer.ViewsCustomer.Views  5      F BLocalCommon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullT9clr-namespace:LocalCommon.ViewModels;assembly=LocalCommonLocalCommon.ViewModels 5      +    %Customer.Views.StatsAndRecommendation   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Customer.Views     5      P
ViewModels9clr-namespace:LocalCommon.ViewModels;assembly=LocalCommon     5        N� Title$  StatsAndRecommendation��5
       � DataContext 5      <  6LocalCommon.ViewModels.StatsAndRecommendationViewModel  5   
   .��5      � ���	#FFE5E5E5.+�5   
   ]� .+�5      �� $	��Top=�6   $��Stats and Recommendation��6)   $��Center=�6L   $��	10,10,0,0q�6i   $	��Top=�6|   $��16(�6�   � 5      
�������$	��357��6&   $	��Top=�63   .+�5      �� $��Select Line��6   $
��Left=�6.   $��	10,10,0,0q�6I   $	��Top=�6\    J� RenderTransformOrigin$ 0.485,-0.038&�6t   �� 5      $
��Left=�6_   $��
105,10,0,0q�6z   $	��Top=�6�   $	��120��6�   ��6   �� *Lines+ �� SelectedItem 69   �� *SelectedLine+��5      �� 5      .R�5      �� ��6(   �� *Number+6B   5      5      �� 5      $��	Calculate��6>   $
��Left=�6R   $��	75,68,0,0q�6m   $	��Top=�6�   $��75��6�   ��6   �� *CalculateCommand+6�   �� 5      $
��Left=�6   $��
10,105,0,0q�63   $	��Top=�6G   .��5      ��  �� Orientation$ Vertical=�6!   .+�5       �� �� 5!      $
��Bold"�6$   $��Total Price��66   � 5"       � ColumnDefinitions 5#      �� 5$   "   $	��200 �63   �� 5%   "   $��* �63    � RowDefinitions 5'      �� 5(   "   $��* �60   �� 5)   "   $��* �60   �� 5*   "   $��* �60   �� 5+   "   $��* �60   .+�5-      �� $ 
Horizontal=�6)   .+�5.   "   �� $��Total Minutes: ��6,   �� 5/   "   ��6,   �� *ClientStats.TotalMinutes+50      �� 51      $��1��6)   $ 
Horizontal=�69   .+�52   "   �� $��Total SMS: ��6,   �� 53   "   ��6,   �� *ClientStats.TotalSMS+54      �� 55      $��1��6(   $!��Total Minutes of Top Number��65   �� 56      $��1��6(   $��1��65   ��6E   �� *#!ClientStats.TotalMinutesTopNumber+�� 57      $��2��6(   $$��Total Minutes of Top 3 Numbers��65   �� 58      $��2��6(   $��1��65   ��6E   �� *$"ClientStats.TotalMinutesTop3Number+�� 59      $��3��6(   $��Total Minutes With Family��65   �� 5:      $��3��6(   $��1��65   ��6E   �� * ClientStats.TotalMinutesFamily+5;      �� 5<      �� 5=      $
��Bold"�6$   $��Recommendation��66   � 5>       5?      �� 5@   "   $	��200 �63   �� 5A   "   $��* �63    5C      �� 5D   "   $��* �60   �� 5E   "   $��* �60   �� 5F   "   $��* �60   .+�5H      �� $ 
Horizontal=�6)   .+�5I   "   �� $
��Bold"�6,   $��Package ��6>   �� 5J   "   $
��Bold"�6,   ��6>   �� *)'ClientStats.Recommendation1.PackageName+ �� TargetNullValue$ -��5K      �� 5L      $��1��6)   $ 
Horizontal=�69   .+�5M   "   �� $
��Bold"�6,   $��Price: ��6>   �� 5N   "   $
��Bold"�6,   ��6>   �� **(ClientStats.Recommendation1.PackagePrice+$ -��5O      �� 5P      $��1��6)   $ 
Horizontal=�66   .+�5Q   "   �� $��Package ��6,   �� 5R   "   ��6,   �� *)'ClientStats.Recommendation2.PackageName+$ -��5S      �� 5T      $��1��6)   $��1��66   $ 
Horizontal=�6F   .+�5U   "   �� $��Price: ��6,   �� 5V   "   ��6,   �� **(ClientStats.Recommendation2.PackagePrice+$ -��5W      �� 5X      $��2��6)   $ 
Horizontal=�66   .+�5Y   "   �� $��Package ��6,   �� 5Z   "   ��6,   �� *)'ClientStats.Recommendation3.PackageName+$ -��5[      �� 5\      $��2��6)   $��1��66   $ 
Horizontal=�6F   .+�5]   "   �� $��Price: ��6,   �� 5^   "   ��6,   �� **(ClientStats.Recommendation3.PackagePrice+$ -��5_      5`      5b      5c      �� 5d      $
��Left=�6   $��
10,324,0,0q�6U   $	��Top=�6j   
���  ��$ 0.7,0.3&�6�   ��63   �� *ErrorMessage+6�   �� 5e      $
��Left=�6   $��
10,324,0,0q�6S   $	��Top=�6g   
����  �$ 0.7,-1.6&�6�   ��63   �� *InfoMessage+6�   5g      5h      5j      5k      