   M S B A M L   `   `   `  ����J  FCustomerService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CustomerService.ViewsCustomerService.Views  5      G(clr-namespace:CustomerService.ViewModelsCustomerService.ViewModels  5      +    %CustomerService.Views.LineInformation   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:CustomerService.Views     5      ?
ViewModels(clr-namespace:CustomerService.ViewModels     5        N� Title$  LineInformation��5       N� 
FontFamily$ Microsoft Sans Serif)�6    � DataContext 5      9   3CustomerService.ViewModels.LineInformationViewModel  5   
   .��5      � ���	#FFE5E5E5.+�5   
   ]� .+�5      �� $	��Top=�6   $��Line Information��6)   $��Center=�6D   $��	10,10,0,0q�6a   $	��Top=�6t   $��16(�6�   � 5      
�������.+�5      �� $��Select Line��6   $
��Left=�6.   $��	10,10,0,0q�6I   $	��Top=�6\    J� RenderTransformOrigin$ -0.184,0.115&�6t   �� 5      $��Number��6   $
��Left=�6)   $��	10,45,0,0q�6D   $	��Top=�6W   $ -0.184,0.115&�6o   �� 5      $
��Left=�6_   $��
121,10,0,0q�6z   $	��Top=�6�   $	��120��6�   ��6   �� *Lines+ �� SelectedItem 69   �� *SelectedLine+��5      �� 5      .R�5      �� ��6(   �� *Number+6B   5      5      �� 5!      $
��Left=�6?   $��23��6Z   $��
121,49,0,0q�6f    �� TextWrapping$
 Wrap=�6z   $	��Top=�6�   $��83��6�   ��6   �� *SelectedLineNumber+6�   �� 5"      $��Select a Package��6   $
��Left=�63   $��	10,83,0,0q�6N   $	��Top=�6a   $ -0.184,0.115&�6y   �� 5#      $
��Left=�6g   $��
121,87,0,0q�6�   $	��Top=�6�   $	��120��6�   ��6   �� *
Packages+ 6=   �� *SelectedPackage+��5$      �� 5%      .R�5&      �� ��6(   �� *PackageName+6G   5'      5)      �� 5*      $��
XminYPrice��6Q   $
��Left=�6f   $��
13,135,0,0q�6�   $	��Top=�6�    d� 	IsChecked 6   �� *!CurrentPackageXminYpriceChecked+6�   �� 5+      $��Minutes��6   $
��Left=�6*   $��115,129,0,0q�6E   $	��Top=�6Z   $ -0.184,0.115&�6r   �� 5,      $
��Left=�6V   $��23��6q   $��196,130,0,0q�6}   $
 Wrap=�6�   $	��Top=�6�   $��45��6�   ��6   �� *CurrentPackageMinutes+ �� TargetNullValue$  ��6�   �� 5-      $��Price��6   $
��Left=�6(   $��276,129,0,0q�6C   $	��Top=�6X   $ -0.184,0.115&�6p   �� 5.      $
��Left=�6S   $��23��6n   $��327,130,0,0q�6z   $
 Wrap=�6�   $	��Top=�6�   $��50��6�   ��6   �� *CurrentPackagePrice+$  ��6�   �� 5/      $��Family Discount��6U   $
��Left=�6o   $��
13,171,0,0q�6�   $	��Top=�6�    6   �� *%#CurrentPackageFamilyDiscountChecked+6�   �� 50      $��Friends��6O   $
��Left=�6a   $��
13,205,0,0q�6|   $	��Top=�6�    6   �� *CurrentPackageFriendsChecked+6�   �� 51      $
��Left=�6G   $��23��6b   $��108,197,0,0q�6n   $
 Wrap=�6�   $	��Top=�6�   $��80��6�   $ 0.475,1.043&�6�   ��6   �� *CurrentPackageFriendNumber1+6�   �� 52      $
��Left=�6G   $��23��6b   $��200,197,0,0q�6n   $
 Wrap=�6�   $	��Top=�6�   $��80��6�   ��6   �� *CurrentPackageFriendNumber2+6�   �� 53      $
��Left=�6G   $��23��6b   $��297,197,0,0q�6n   $
 Wrap=�6�   $	��Top=�6�   $��80��6�   ��6   �� *CurrentPackageFriendNumber3+6�   �� 54      $��Favorite Number��6V   $
��Left=�6p   $��
13,267,0,0q�6�   $	��Top=�6�    6   �� *&$CurrentPackageFavouriteNumberChecked+6�   �� 55      $��Total Fixed Price��6   $
��Left=�64   $��
26,290,0,0q�6O   $	��Top=�6c   �� 56      $
��Left=�6V   $��23��6q   $��183,287,0,0q�6}   $
 Wrap=�6�   $	��Top=�6�   $��97��6�    �� 
IsReadOnly . ��6   �� *CurrentPackageTotalFixedPrice+	 �� Mode$	 OneWay=�6�   �� 57      $
��Save��69   $
��Left=�6I   $��	10,2,0,10q�6d   $��2��6w   $��Bottom=�6�   $��75��6�   ��6   �� *SaveCommand+6�   �� 58      $��Delete��6;   $��center=�6L   $��0,0,0,10q�6i   $��2��6|   $��Bottom=�6�   $��75��6�   ��6   �� *DeleteCommand+6�   �� 59      $��Clear��6:   $��Right=�6J   $��	0,0,10,10q�6f   $��2��6y   $��Bottom=�6�   $��75��6�   ��6   �� *ClearCommand+6�   �� 5:      $��Client:��6   $
��Left=�6*   $��
246,10,0,0q�6E   $	��Top=�6Y   $ -0.184,0.115&�6q   �� 5;      $
��Left=�6   $��
13,319,0,0q�6U   $	��Top=�6j   
���  ����63   �� *ErrorMessage+6�   �� 5<      $
��Left=�6   $��
13,319,0,0q�6S   $	��Top=�6g   
����  ���63   �� *InfoMessage+6   �� 5>      $
��Left=�6H   $��
295,10,0,0q�6c   $	��Top=�6w   $ -0.184,0.115&�6�   ��6   �� *ClientAsString+$	 OneWay=�6�   �� 5?      $��Discount Percentage��6   $
��Left=�66   $��
30,232,0,0q�6Q   $	��Top=�6e   $ -0.184,0.115&�6}   �� 5@      $
��Left=�6a   $��23��6|   $��159,233,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $��45��6�   ��6   �� *" CurrentPackageDiscountPercentage+$  ��6�   �� 5A      $��	Calculate��6   $
��Left=�6\   $��
285,0,0,71q�6w   $��Bottom=�6�   $��75��6�   $��52��6�   ��6-   �� *CalcTotalFixedPriceCommand+6�   5E      5F      5H      5J      