   M S B A M L   `   `   `  ����J  FCustomerService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CustomerService.ViewsCustomerService.Views  5      F BLocalCommon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullT9clr-namespace:LocalCommon.ViewModels;assembly=LocalCommonLocalCommon.ViewModels 5      )    #CustomerService.Views.ReceiptResult   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:CustomerService.Views     5      P
ViewModels9clr-namespace:LocalCommon.ViewModels;assembly=LocalCommon     5        N� Title$  ReceiptResult��5
       � DataContext 5      3  -LocalCommon.ViewModels.ReceiptResultViewModel  5   
   .��5      � .+�5   
   � ���	#FFE5E5E5.+�5      ]� .+�5      �� $	��Top=�6   $��Receipt��6-   $��Center=�6?   $��	10,10,0,0q�6\   $	��Top=�6o   $��16(�6�   � 5      
�������.+�5      �� $
��Auto=�6#   $
��Left=�6G   $	��276��6b   $��	10,35,0,0q�6o   $	��Top=�6�   $	��551��6�   .��5      �� ��6'   �� *ClientInvoice.LineInvoices+��5      �� 5   "   .R�5   &   ��  �� Orientation$ Vertical=�61   .+�5   *   �� $ 
Horizontal=�65   .+�5   .   �� $
��Bold"�68   $��Line Number ��6J   �� 5    .   �� 5!   .   $
��Bold"�68   ��6J   �� *
LineNumber+ �� TargetNullValue$	 N/A��5"   +   �� 5#   *   �� 5$   *   $ 
Horizontal=�65   .+�5%   .   �� $
��Bold"�68   $��Price: ��6J   �� 5&   .   $
��Bold"�68   ��6J   �� *
TotalPrice+�� 5'   .   $
��Bold"�68   $��        Package Info: ��6J   �� 5(   .   $
��Bold"�68   ��6J   �� *PackageInfo+5)   +   �� 5*   *   $
��Bold"�64   $��Package��6F   � 5+   *    � RowDefinitions 5,   .   �� 5-   2   $��* �6A   �� 5.   2   $��* �6A    � ColumnDefinitions 50   .   �� 51   2   $	��150 �6D   �� 52   2   $	��225 �6D   �� 53   2   $��* �6D   .+�55   .   �� $ 
Horizontal=�69   .+�56   2   �� 
����  �$��	Minutes: ��6N   �� 57   2   ��6<   �� *	Minutes+58   /   �� 59   .   $ 
Horizontal=�69   $��1��6R   .+�5:   2   �� 
����  �$��Minutes Left in Package: ��6N   �� 5;   2   ��6<   �� *MinutesLeftInPackage+5<   /   �� 5=   .   $ 
Horizontal=�69   $��2��6R   .+�5>   2   �� 
����  �$��Package % Usage: ��6N   �� 5?   2   
����  ���6N   �� *PackagePercentUsage+�� 5@   2   
����  �$��%��6N   5A   /   �� 5B   .   $��1��68   
����  �$��Package Price: ��6W   �� 5C   .   $��1��68   $��2��6E   ��6U   �� *PackagePrice+5D   +   �� 5E   *   $ 
Horizontal=�65   �� 5F   *   �� 5G   *   $
��Bold"�64   $��Out of Package��6F   � 5H   *    5I   .   �� 5J   2   $��* �6A   �� 5K   2   $��* �6A   �� 5L   2   $��* �6A    5N   .   �� 5O   2   $	��225 �6D   �� 5P   2   $	��150 �6D   �� 5Q   2   $��* �6D   .+�5T   .   �� $ 
Horizontal=�69   .+�5U   2   �� 
����  �$$��Minutes beyond package limit: ��6N   �� 5V   2   ��6<   �� *MinutesBeyondPackageLimit+5W   /   �� 5X   .   $��1��69   $ 
Horizontal=�6I   .+�5Y   2   �� 
����  �$��Price per Minute: ��6N   �� 5Z   2   ��6<   �� *MinutePrice+5[   /   �� 5\   .   $��2��69   $ 
Horizontal=�6I   .+�5]   2   �� 
����  �$��Total: ��6N   �� 5^   2   ��6<   �� *TotalMinutesPrice+5_   /   �� 5`   .   $��1��69   $ 
Horizontal=�6F   .+�5a   2   �� 
����  �$��Number of SMS Messages: ��6N   �� 5b   2   ��6<   �� *SMS+5c   /   �� 5d   .   $��1��6:   $��1��6G   $ 
Horizontal=�6W   .+�5e   2   �� 
����  �$��Price per SMS: ��6N   �� 5f   2   ��6<   �� *
SMSPrice+5g   /   �� 5h   .   $��1��69   $��2��6F   $ 
Horizontal=�6V   .+�5i   2   �� 
����  �$��Total: ��6N   �� 5j   2   ��6<   �� *TotalSMSPrice+5k   /   �� 5l   .   $��2��68   
����  �$��Total:��6W   �� 5m   .   $��2��68   $��2��6E   ��6U   �� *OutOfPackageTotalPrice+5n   +   �� 5p   *   �� 5q   *   5r   '   5s   #   5u      5v      �� 5x      $
��Left=�6   $��10,4,0,0q�67   $	��Top=�6I   .��5y      �  5z      �� 5{   "   $	��150 �63   �� 5|   "   $��75 �63   �� 5}   "   $��75 �63   �� 5~   "   $	��125 �63   .+�5�      �� $ 
Horizontal=�6)   .+�5�   "   �� $
��Bold"�6,   $��Client Name: ��6>   �� 5�   "   $
��Bold"�6,   ��6>   �� *ClientInvoice.ClientName+5�      �� 5�      $��1��6)   $ 
Horizontal=�69   .+�5�   "   �� $
��Bold"�6,   $��Month: ��6>   �� 5�   "   $
��Bold"�6,   ��6>   �� *ClientInvoice.Month+5�      �� 5�      $��2��6)   $ 
Horizontal=�69   .+�5�   "   �� $
��Bold"�6,   $��Year: ��6>   �� 5�   "   $
��Bold"�6,   ��6>   �� *ClientInvoice.Year+5�      �� 5�      $��3��6)   $ 
Horizontal=�69   .+�5�   "   �� $
��Bold"�6,   $��Total Price: ��6>   �� 5�   "   $
��Bold"�6,   ��6>   �� *ClientInvoice.TotalPrice+5�      5�      5�      �� 5�      $��Export��6?   $
��Left=�6P   $��	497,7,0,0q�6k   $	��Top=�6~   $��64��6�   ��6   �� *ExportCommand+6�   �� 5�      
���  ��$
��Left=�6N   $��
10,316,0,0q�6i   $	��Top=�6}   ��6   �� *ErrorMessage+6}   5�      5�      5�      5�      5�      