   M S B A M L   `   `   `  ����J  FCustomerService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CustomerService.ViewsCustomerService.Views  5      G(clr-namespace:CustomerService.ViewModelsCustomerService.ViewModels  5      A =Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_<clr-namespace:Common.ModelToBlClient.Invoice;assembly=CommonCommon.ModelToBlClient.Invoice 6C   %    CustomerService.Views.Simulator   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:CustomerService.Views     5      ?
ViewModels(clr-namespace:CustomerService.ViewModels     5      PInvoice<clr-namespace:Common.ModelToBlClient.Invoice;assembly=Common     6C     N� Title$  	Simulator��5
       N� 
FontFamily$ Microsoft Sans Serif)�6    � DataContext 5      3   -CustomerService.ViewModels.SimulatorViewModel  5   
   .��5      � ���	#FFE5E5E5.+�5   
   ]� .+�5      �� $	��Top=�6   $��	Simulator��6)   $��Center=�6=   $��	10,10,0,0q�6Z   $	��Top=�6m   $��16(�6�   � 5      
�������.+�5      �� $��	Client ID��6   $
��Left=�6,   $��	10,10,0,0q�6G   $	��Top=�6Z   �� 5      $��Selected Line��6   $
��Left=�60   $��	10,56,0,0q�6K   $	��Top=�6^   �� 5      $
��Left=�6s   $��
131,14,0,0q�6�   $	��Top=�6�   $	��133��6�   ��6   �� *ClientIdNumbers+ �� SelectedItem 6C   �� *SelectedClientIdNumber+6�   �� 5      $
��Left=�6_   $��
131,58,0,0q�6z   $	��Top=�6�   $	��133��6�    J� RenderTransformOrigin$ 
0.708,3.75&�6�   ��6   �� *Lines+ 69   �� *SelectedLine+��5      �� 5      .R�5      �� ��6(   �� *Number+5       5"      �� 5$      $��Min Duration��6   $
��Left=�6/   $��
10,111,0,0q�6J   $	��Top=�6^   �� 5%      $
��Left=�6L   $��23��6g   $��108,112,0,0q�6s    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��110��6�   ��6   �� *" SimulationParameters.MinDuration+6�   �� 5&      $��Max Duration��6   $
��Left=�6/   $��223,111,0,0q�6J   $	��Top=�6_   �� 5'      $
��Left=�6L   $��23��6g   $��316,112,0,0q�6s   $
 Wrap=�6�   $	��Top=�6�   $	��110��6�   ��6   �� *" SimulationParameters.MaxDuration+6�   �� 5(      $��Number of Calls/SMS��6   $
��Left=�66   $��
10,178,0,0q�6Q   $	��Top=�6e   �� 5)      $
��Left=�6S   $��23��6n   $��154,182,0,0q�6z   $
 Wrap=�6�   $	��Top=�6�   $	��110��6�   ��6   �� *)'SimulationParameters.NumberOfCallsOrSMS+6�   �� 5*      $	��SMS��6J   $
��Left=�6X   $��332,184,0,0q�6s   $	��Top=�6�    d� 	IsChecked 6   �� *SimulationParameters.SMS+6�   �� 5+      $��Send To��6   $
��Left=�6*   $��
10,222,0,0q�6E   $	��Top=�6Y   �� 5,      $
��Left=�6   $��154,226,0,0q�6r   $	��Top=�6�   $	��133��6�   $ 
0.708,3.75&�6�    66   �� *$"SimulationParameters.SendToOptions+.@�5-      2  ,Common.ModelToBlClient.Invoice.SendToOptions Friends=�65    5.      
Family=�64    5/      General=�65    50      All=�61   51      �� 52      $��Simulate��6=   $��center=�6P   $��0,0,0,10q�6m   $��2��6�   $��Bottom=�6�   $��75��6�   ��6   �� *SimulateCommand+6�   �� 53      $
��Left=�6   $��
11,264,0,0q�6T   $	��Top=�6i   
���  ����63   �� *ErrorMessage+6�   �� 54      $
��Left=�6   $��
11,264,0,0q�6S   $	��Top=�6g   
����  ���63   �� *InfoMessage+6   55      59      5:      5;      