   M S B A M L   `   `   `  ����J  FCustomerService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CustomerService.ViewsCustomerService.Views  5      G(clr-namespace:CustomerService.ViewModelsCustomerService.ViewModels  5      -    'CustomerService.Views.ClientInformation   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:CustomerService.Views     5      ?
ViewModels(clr-namespace:CustomerService.ViewModels     5        N� Title$  Client Information��5       N� 
FontFamily$ Microsoft Sans Serif)�6"    � DataContext 5      ;   5CustomerService.ViewModels.ClientInformationViewModel  5   
   .��5      � ���	#FFE5E5E5.+�5   
   ]� .+�5      �� $	��Top=�6   $��Cleint Information��6)   $��Center=�6F   $��	10,10,0,0q�6c   $	��Top=�6v   $��16(�6�   � 5      
������� � RowDefinitions 5      �� 5      $	��50* �6$   $��50��61   �� 5      $
��190* �6$   $	��175��62   �� 5      $	��35* �6$   �� 5      $	��32* �6$   $��30��61   .+�5       �� $��Select By ID��6   $
��Left=�6/   $��	10,10,0,0q�6J   $	��Top=�6]   $��26��6u   $��75��6�    J� RenderTransformOrigin$ 1.125,3.962&�6�   �� 5!      -   5         ��Name$ cmbSelectedID��5!      $
��Left=�6�   $��
115,14,0,0q�6�   $	��Top=�6�   $	��150��6�   $��22��6�   ��63   �� *ClientsIdNumbers+ �� SelectedItem 6\   �� *SelectedClientIdNumber+6�   � 5"      $��1��6   $��3��6%    � ColumnDefinitions 5#      �� 5$      $	��200 �6+   $	��200��67   �� 5%      $��* �6+   .+�5'      �� $
��Name��6   $
��Left=�6+   $��	10,10,0,0q�6F   $	��Top=�6Y   �� 5(      -   5         ��Name$ txtName��5(      $
��Left=�6T   $��23��6o   $��	57,14,0,0q�6{   	 �� TextWrapping$
	 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6/   �� *CurrentClient.Name+6�   �� 5)      $��ID��6   $
��Left=�6)   $��	10,65,0,0q�6D   $	��Top=�6W   �� 5*      -   5        $ txtID��5*      $
��Left=�6\   $��23��6w   $��	57,69,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6.   �� *CurrentClient.ClientIdNumber+6�   �� 5+      $
��Type��6   $
��Left=�6+   $��
10,120,0,0q�6F   $	��Top=�6Z   �� 5,      -   5        $ txtType��5,      $��23��6�   $��
57,124,0,0q�6�   $	��Top=�6�   $
��Left=�6�   $	��120��6�   ��60   �� *ClientTypes+ 6T   �� *ClientTypeOfCurrentClient+��5-      �� 5.      .R�5/   "   �� 
 �� Orientation$
 
Horizontal=�6-   .+�50   &   �� ��60   �� *
TypeName+6L   51   #   52      54      �� 55      $��	Last Name��6   $
��Left=�60   $��	14,10,0,0q�6K   $	��Top=�6^   $��1��6v   �� 56      -   5        $ txtLastName��56      $
��Left=�6\   $��23��6w   $��
117,14,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $	��120��6�   $��1��6�   ��63   �� *CurrentClient.LastName+6�   �� 57      $��Address��6   $
��Left=�6.   $��	14,65,0,0q�6I   $	��Top=�6\   $��1��6t   �� 58      -   5        $ 
txtAddress��58      $
��Left=�6Z   $��23��6u   $��
117,69,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $	��120��6�   $��1��6�   ��63   �� *CurrentClient.Address+6�   �� 59      $��Contact Number��6   $
��Left=�65   $��
14,120,0,0q�6P   $	��Top=�6d   $��1��6|   �� 5:      -   5        $ txtContactNumber��5:      $
��Left=�6g   $��23��6�   $��117,124,0,0q�6�   $
	 Wrap=�6�   $	��Top=�6�   $	��120��6�   $��1��6�   ��69   �� *CurrentClient.ContactNameber+6�   �� 5;      $
��Type��6   $
��Left=�6+   $��
10,120,0,0q�6F   $	��Top=�6Z   5<      �� 5=      $
��Left=�6   $��	10,15,0,0q�6U   $	��Top=�6i   
���  ��$��2��6�   ��63   �� *ErrorMessage+6�   �� 5>      $
��Left=�6   $��	10,15,0,0q�6S   $	��Top=�6f   
����  �$��2��6�   ��63   �� *InfoMessage+6�   �� 5?      $
��Save��6   $
��Left=�6H   $��	10,0,0,10q�6c   $��3��6v   $��Bottom=�6�   $��75��6�   ��6(   �� *SaveCommand+6�   �� 5@      $��Delete��6   $��Center=�6L   $��210,0,210,10q�6i   $��3��6�   $��Bottom=�6�   $��75��6�   ��6*   �� *DeleteCommand+6�   �� 5A      $��Clear��6   $��Right=�6J   $��	0,0,10,10q�6f   $��3��6y   $��Bottom=�6�   $��75��6�   ��6)   �� *ClearCommand+6�   5C      5G      5H      5K      