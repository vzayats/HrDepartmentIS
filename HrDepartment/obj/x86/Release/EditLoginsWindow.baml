   M S B A M L   `   `   `  ����   HrDepartment#    HrDepartment.EditLoginsWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     k gTelerik.Windows.Documents.Core, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7w sTelerik.Windows.Controls.DataVisualization, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.RibbonView, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n	 jTelerik.Windows.Controls.GridView, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a
 ]Telerik.Windows.Data, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Input, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.Charting, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Chart, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7b ^Telerik.Windows.Maths, Version=2015.3.930.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Utelerik1http://schemas.telerik.com/2008/xaml/presentation     	 
       -     � Title$J  DНалаштування користувацьких записів��$��286.142��$��510.872�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � Icon$ Images/Edit User-100.png��.��� .+�,  &Telerik.Windows.Controls.RadTabControl  $��Stretch=�$��Stretch=�$��0,0,0,40q�.@�)  #Telerik.Windows.Controls.RadTabItem  -     Name$ EditRadTabItem��$H��BРедагування користувацьких записів��$��30��$	��230��.��� 
������ $��0,0,0,0q�.+��� $L��FЗмінити дані або видалити користувача��$
��Left=�$��	10,10,0,0q�$	��Top=�$��99��$	��470��.��� .+��� $
��Left=�$��	10,13,0,0q�$��NoWrap=�$��Логін:��$	��Top=��� -    ��Name$ LoginTextBox��$
��Left=�$��23��$��62,9,0,0q� �� TextWrapping$ NoWrap=�$�� ��$	��Top=�$	��386���� $
��Left=�$��	10,46,0,0q�$��NoWrap=�$��Пароль:��$	��Top=�G� -    G�Name$ PasswordBox��$
��Left=�$��23��$��	62,43,0,0q�$	��Top=�$	��386���� -    ��Name$ UpdateButton��$��Змінити��$
��Left=�$��405,114,0,0q�$	��Top=�$��75��$��24���� -   $ DeleteButton��$��Видалити��$
��Left=�$��
10,114,0,0q�$	��Top=�$��75��$��24��  -   $ CreateRadTabItem��$<��6Додавання нового користувача��$��30��$	��200��.��� 
������ $��0,0,0,0q�.+��� $6��0Додати нового користувача��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��124��$	��470��.��� .+��� $
��Left=�$��	10,13,0,0q�$��NoWrap=�$��Логін:��$	��Top=��� -   $ LoginCreateTextBox��$
��Left=�$��23��$��	112,9,0,0q�$ NoWrap=�$�� ��$	��Top=�$	��336���� $
��Left=�$��	10,46,0,0q�$��NoWrap=�$��Пароль:��$	��Top=�G� -	   $ PasswordCreateBox��$
��Left=�$��23��$��
112,43,0,0q�$	��Top=�$	��336���� $
��Left=�$��	10,75,0,0q�$��NoWrap=�$$��Тип користувача:��$	��Top=��� -
   	 ��Name$	 LoginTypeComboBox��$
��Left=�$��
112,73,0,0q�$	��Top=�$	��336��.@��� -   $��Administrator��$ ��Адміністратор���� -   $
��User��$��Користувач���� -   $ UserAddButton��$��Додати��$
��Left=�$��405,139,0,0q�$	��Top=�$��75��$��24���� -   $ CloseButton��$��Закрити��$
��Left=�$��409,217,0,0q�$	��Top=�$��75��$��24��