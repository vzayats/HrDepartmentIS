   M S B A M L   `   `   `  ����   HrDepartment*    $HrDepartment.AddEditDepartmentWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     k gTelerik.Windows.Documents.Core, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7w sTelerik.Windows.Controls.DataVisualization, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.RibbonView, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n	 jTelerik.Windows.Controls.GridView, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a
 ]Telerik.Windows.Data, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.Charting, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Chart, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7b ^Telerik.Windows.Maths, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Utelerik1http://schemas.telerik.com/2008/xaml/presentation     	 
       -     � Title$   ��$	��279��$��372.5�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � Icon$ Images/Org Unit-96.png��.��� .+��� $4��.Інформація про підрозділ��$
��Left=�$��10,5,0,0q�$	��Top=�$	��340��$	��198��.��� .+��� $
��Left=�$��	10,58,0,0q�$��NoWrap=�$ ��ПІБ керівника:��$	��Top=��� -    ��Name$ FiaComboBox��$
��Left=�$��	10,79,0,0q�$	��Top=�$	��302������ �� $
��Left=�$��
10,112,0,0q�$��NoWrap=�$"��Номер кабінету:��$	��Top=��� $
��Left=�$��	10,10,0,0q�$��NoWrap=�$&�� Назва підрозідлу:��$	��Top=��� -    ��Name$ DepNameTextBox��$
��Left=�$��23��$��	10,31,0,0q� �� TextWrapping$ NoWrap=�$�� ��$	��Top=�$	��302��/  )Telerik.Windows.Controls.RadNumericUpDown  -     Name$ OfficeNumericUpDown��$
��Left=�$��124,109,0,0q�$	��Top=�$	��188��   
IsEditable . +  %Telerik.Windows.Controls.RadRangeBase	   Minimum$	 0Q�
   Maximum$

 2000Q�   HideTrailingZeros . �� $
��Left=�$��
10,139,0,0q�$��NoWrap=�$"��Номер телефону:��$	��Top=�1  +Telerik.Windows.Controls.RadMaskedTextInput  -     Name$ TelephoneTextInput��1  +Telerik.Windows.Controls.RadMaskedInputBase   Mask$ +###(###)###-##-##��$
��Left=�   EmptyContent$0 *Введіть номер телефону��$��124,136,0,0q�$	��Top=�$	��188���� -    ��Name$ 	AddButton��$��Додати��$
��Left=�$��275,208,0,0q�$	��Top=�$��75��$��25��$y�Hidden=��� -   $ ChangeButton��$��Змінити��$
��Left=�$��275,208,0,0q�$	��Top=�$��76��$��25��$y�Hidden=�