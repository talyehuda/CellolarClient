   M S B A M L   `   `   `  ����J  FCustomerService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CustomerService.ViewsCustomerService.Views  5      G(clr-namespace:CustomerService.ViewModelsCustomerService.ViewModels  5      (    "CustomerService.Views.SelectClient   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:CustomerService.Views     5      ?
ViewModels(clr-namespace:CustomerService.ViewModels     5        N� Title$  SelectClient��5
       � DataContext 5      6   0CustomerService.ViewModels.SelectClientViewModel  5   
   .��5      � ���	#FFE5E5E5.+�5   
   ]� .+�5      �� $	��Top=�6   $��Select a Client��6)   $��Center=�6C   $��	10,10,0,0q�6`   $	��Top=�6s   $��16(�6�   � 5      
�������.+�5      �� $��	Client ID��6   $
��Left=�6,   $��	10,10,0,0q�6G   $	��Top=�6Z   �� 5      $
��Left=�6   $��	70,14,0,0q�6�   $	��Top=�6�   $	��120��6�   ��66   �� *ClientIdNumbers+ �� SelectedItem 6^   �� *SelectedClientIdNumber+6�   �� 5      -   5        $��Select��5   ;   $
��Left=�6L   $��	4,142,0,0q�6g   $	��Top=�6z   $��75��6�   ��6   �� *SelectCommand+6�   �� 5      $��Cancel��6;   $
��Left=�6L   $��
84,142,0,0q�6g   $	��Top=�6{   $��75��6�   ��6   �� *CancelCommand+6�   �� 5      $��Name:��6   $
��Left=�6(   $��	10,41,0,0q�6C   $	��Top=�6V   �� 5      $
��Left=�6N   $��	59,41,0,0q�6i   $	��Top=�6|   ��6   �� *SelectedClient.Name+ �� Mode$ OneWay=�6|   �� 5      $��
Last Name:��6   $
��Left=�6-   $��	10,72,0,0q�6H   $	��Top=�6[   �� 5      $
��Left=�6Q   $��	84,72,0,0q�6l   $	��Top=�6    J� RenderTransformOrigin$ 1.2,4&�6�   ��6   �� *SelectedClient.LastName+$ OneWay=�6�   �� 5      $
��Left=�6   $��
10,103,0,0q�6T   $	��Top=�6i   
���  ����63   �� *ErrorMessage+6�   �� 5      $
��Left=�6   $��
10,103,0,0q�6S   $	��Top=�6g   
����  ���63   �� *InfoMessage+6   5      5       5"      5#      