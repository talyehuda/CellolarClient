   M S B A M L   `   `   `  ����J  FCustomerService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CustomerService.ViewsCustomerService.Views  5      G(clr-namespace:CustomerService.ViewModelsCustomerService.ViewModels  5      8    2CustomerService.Views.ClientStatsAndRecommendation   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:CustomerService.Views     5      ?
ViewModels(clr-namespace:CustomerService.ViewModels     5        N� Title$"  ClientStatsAndRecommendation��5
       � DataContext 5      F  @CustomerService.ViewModels.ClientStatsAndRecommendationViewModel  5   
   .��5      � ���	#FFE5E5E5.+�5   
   ]� .+�5      �� $	��Top=�6   $%��Client Stats and Recommendation��6)   $��Center=�6S   $��	10,10,0,0q�6p   $	��Top=�6�   $��16(�6�   � 5      
�������.+�5      �� $��Select Client ID��6   $
��Left=�63   $��	10,10,0,0q�6N   $	��Top=�6a   �� 5      $
��Left=�6t   $��
105,10,0,0q�6�   $	��Top=�6�   $	��120��6�   ��6   �� *ClientIdNumbers+ �� SelectedItem 6C   �� *SelectedClientIdNumber+6�   �� 5      $��Select Line��6   $
��Left=�6.   $��	10,53,0,0q�6I   $	��Top=�6\    J� RenderTransformOrigin$ 0.485,-0.038&�6t   �� 5      $
��Left=�6_   $��
105,53,0,0q�6z   $	��Top=�6�   $	��120��6�   ��6   �� *Lines+ 69   �� *SelectedLine+��5      �� 5      .R�5      �� ��6(   �� *Number+6B   5      5      �� 5      $��	Calculate��6>   $
��Left=�6R   $��	77,91,0,0q�6m   $	��Top=�6�   $��75��6�   ��6   �� *CalculateCommand+6�   �� 5       $
��Left=�6   $��
10,121,0,0q�63   $	��Top=�6G   .��5!      ��  �� Orientation$ Vertical=�6!   .+�5"      �� $ 
Horizontal=�6%   .+�5#      �� $
��Bold"�6(   $��Client Value: ��6:   �� 5$      $
��Bold"�6(   ��6:   �� *ClientStats.ClientValue+5%      �� 5&      �� 5'      $
��Bold"�6$   $��Total Price��66   � 5(       � ColumnDefinitions 5)      �� 5*   "   $	��200 �63   �� 5+   "   $��* �63    � RowDefinitions 5-      �� 5.   "   $��* �60   �� 5/   "   $��* �60   �� 50   "   $��* �60   �� 51   "   $��* �60   .+�53      �� $ 
Horizontal=�6)   .+�54   "   �� $��Total Minutes: ��6,   �� 55   "   ��6,   �� *ClientStats.TotalMinutes+56      �� 57      $��1��6)   $ 
Horizontal=�69   .+�58   "   �� $��Total SMS: ��6,   �� 59   "   ��6,   �� *ClientStats.TotalSMS+5:      �� 5;      $��1��6(   $!��Total Minutes of Top Number��65   �� 5<      $��1��6(   $��1��65   ��6E   �� *#!ClientStats.TotalMinutesTopNumber+�� 5=      $��2��6(   $$��Total Minutes of Top 3 Numbers��65   �� 5>      $��2��6(   $��1��65   ��6E   �� *$"ClientStats.TotalMinutesTop3Number+�� 5?      $��3��6(   $��Total Minutes With Family��65   �� 5@      $��3��6(   $��1��65   ��6E   �� * ClientStats.TotalMinutesFamily+5A      �� 5B      �� 5C      $
��Bold"�6$   $��Recommendation��66   � 5D       5E      �� 5F   "   $	��200 �63   �� 5G   "   $��76 �63   �� 5H   "    5J      �� 5K   "   $��* �60   �� 5L   "   $��* �60   �� 5M   "   $��* �60   .+�5O      �� $ 
Horizontal=�6)   .+�5P   "   �� $
��Bold"�6,   $��Package ��6>   �� 5Q   "   $
��Bold"�6,   ��6>   �� *)'ClientStats.Recommendation1.PackageName+ �� TargetNullValue$ -��5R      �� 5S      $��1��6)   $ 
Horizontal=�69   .+�5T   "   �� $
��Bold"�6,   $��Price: ��6>   �� 5U   "   $
��Bold"�6,   ��6>   �� **(ClientStats.Recommendation1.PackagePrice+$ -��5V      �� 5W      $��2��6)   $ 
Horizontal=�69   .+�5X   "   �� $
��Bold"�6,   $��Price for Last Month: ��6>   �� 5Y   "   $
��Bold"�6,   ��6>   �� */-ClientStats.Recommendation1.PriceForLastMonth+$ -��5Z      �� 5[      $��1��6)   $ 
Horizontal=�66   .+�5\   "   �� $��Package ��6,   �� 5]   "   ��6,   �� *)'ClientStats.Recommendation2.PackageName+$ -��5^      �� 5_      $��1��6)   $��1��66   $ 
Horizontal=�6F   .+�5`   "   �� $��Price: ��6,   �� 5a   "   ��6,   �� **(ClientStats.Recommendation2.PackagePrice+$ -��5b      �� 5c      $��1��6)   $��2��66   $ 
Horizontal=�6F   .+�5d   "   �� $��Price for Last Month: ��6,   �� 5e   "   ��6,   �� */-ClientStats.Recommendation2.PriceForLastMonth+$ -��5f      �� 5g      $��2��6)   $ 
Horizontal=�66   .+�5h   "   �� $��Package ��6,   �� 5i   "   ��6,   �� *)'ClientStats.Recommendation3.PackageName+$ -��5j      �� 5k      $��2��6)   $��1��66   $ 
Horizontal=�6F   .+�5l   "   �� $��Price: ��6,   �� 5m   "   ��6,   �� **(ClientStats.Recommendation3.PackagePrice+$ -��5n      �� 5o      $��2��6)   $��2��66   $ 
Horizontal=�6F   .+�5p   "   �� $��Price for Last Month: ��6,   �� 5q   "   ��6,   �� */-ClientStats.Recommendation3.PriceForLastMonth+$ -��5r      5s      5u      5v      �� 5w      $
��Left=�6   $��
10,339,0,0q�6U   $	��Top=�6j   
���  ����63   �� *ErrorMessage+6�   �� 5x      $
��Left=�6   $��
10,339,0,0q�6S   $	��Top=�6g   
����  ���63   �� *InfoMessage+6   5z      5{      5}      5~      