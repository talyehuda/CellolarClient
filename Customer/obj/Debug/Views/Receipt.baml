   M S B A M L   `   `   `  ����C  ?Customer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Customer.ViewsCustomer.Views  5      9!clr-namespace:Customer.ViewModelsCustomer.ViewModels  5          Customer.Views.Receipt   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Customer.Views     5      8
ViewModels!clr-namespace:Customer.ViewModels     5        N� Title$  Receipt��5
       � DataContext 5      *  $Customer.ViewModels.ReceiptViewModel  5   
   .��5      � .+�5   
   � ���	#FFE5E5E5.+�5      ]� .+�5      �� $	��Top=�6   $��Receipt��6-   $��Center=�6?   $��	10,10,0,0q�6\   $	��Top=�6o   $��16(�6�   � 5      
�������.+�5      �� $
��Left=�6=   $��
105,27,0,0q�6Y   $	��Top=�6m   $	��147��6�   ��6   �� *Lines+��5      �� 5      .R�5   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5   &   ��  d� 	IsChecked 6/   �� *
IsSelected+��6P   �� *Item.Number+6r   5   #   5      5      �� 5      $��Select Line(s)��6   $
��Left=�65   $��	10,23,0,0q�6P   $	��Top=�6c   �� 5      $��Select Month��6   $
��Left=�63   $��	10,64,0,0q�6N   $	��Top=�6a   �� 5       $��	Calculate��6B   $
��Left=�6V   $��105,133,0,0q�6q   $	��Top=�6�   $��75��6�   ��6   �� *CalculateCommand+6�   �� 5!      $
��Left=�6e   $��
105,68,0,0q�6�   $	��Top=�6�   $��47��6�   ��6   �� *Months+ �� SelectedItem 6>   �� *SelectedMonth+5"      �� 5#      $��Year:��6   $
��Left=�6,   $��
157,64,0,0q�6G   $	��Top=�6[   �� 5$      $
��Left=�6c   $��
197,68,0,0q�6~   $	��Top=�6�   $��55��6�   ��6   �� *Years+ 6=   �� *SelectedYear+6�   �� 5%      $
��Left=�6   $��	10,95,0,0q�6X   $	��Top=�6l   
���  ����67   �� *ErrorMessage+6�   �� 5&      $
��Left=�6   $��	10,95,0,0q�6W   $	��Top=�6j   
����  ���67   �� *InfoMessage+6�   5'      5(      5*      5+      5,      