   M S B A M L   `   `   `  ���� \  XTelerik.Reporting, Version=9.2.15.1105, Culture=neutral, PublicKeyToken=a9d7983dfcc261beP:clr-namespace:Telerik.Reporting;assembly=Telerik.ReportingTelerik.Reporting   HrDepartment   HrDepartment.ReportWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     c _Telerik.ReportViewer.Wpf, Version=9.2.15.1105, Culture=neutral, PublicKeyToken=a9d7983dfcc261be'trhttp://schemas.telerik.com/wpf  J	reporting:clr-namespace:Telerik.Reporting;assembly=Telerik.Reporting  -     � Title$-  'Формування звітності��$	��600��$
��1100�� � WindowStartupLocation$ CenterScreen=� � Icon$ Images/Reports.png��.��� .+��� $��Оберіть звіт��$
��Left=�$��5,5,0,6q�$��Stretch=�$	��283��.���� $
��Left=�$��Stretch=�$	��272��$��0,5,-1,2q�.@��� -    ��Name$ ListBoxItem1��.����  �� Orientation$ 
Horizontal=�.+��� $��Images/report2.png���� �� $6�0Список працівників (жінки)���� -   $ ListBoxItem2��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $<�6Список працівників (чоловіки)���� -   $ ListBoxItem3��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $<�6Загальний список працівників���� -   $ ListBoxItem4��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $4�.Вікові групи працівників���� -   $ ListBoxItem5��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $5�/Громадянство працівників���� -   $ ListBoxItem6��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $4�.Адресні дані працівників���� -   $ ListBoxItem7��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $-�'Контакти працівників���� -	   $ ListBoxItem8��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $8�2Дата прийняття працівників���� -
   $ ListBoxItem9��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $3�-Працівники та їх статуси���� -   $ ListBoxItem10��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $]�WКількість працівників у відділах (з підсумками)���� -   $ ListBoxItem11��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $_�YКількість працівників у відділах (без підсумків)���� -   $ ListBoxItem12��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $;�5Кількість жінок та чоловіків���� -   $ ListBoxItem13��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $=�7Працівники та оклади/надбавки���� -   $ ListBoxItem14��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $s�mПрийнято на роботу працівників по підрозділах(за увесь час)���� -   $ ListBoxItem15��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $-�'Звільнені працівники���� -   $ ListBoxItem16��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $C�=Інформація про дітей працівників���� -   $ ListBoxItem17��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $^�XІнформація про неповнолітніх дітей працівників���� -   $ ListBoxItem18��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $?�9Інформація про кількість дітей���� -   $ ListBoxItem19��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $8�2Інформація про членів сім'ї���� -   $ ListBoxItem20��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $6�0Сімейний стан працівників���� -   $ ListBoxItem21��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $'�!Стать працівників���� -   $ ListBoxItem22��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $<�6Місце народження працівників���� -   $ ListBoxItem23��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $6�0Паспортні дані (державний)���� -   $ ListBoxItem24��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $I�CПаспортні дані (закордонний паспорт)���� -   $ ListBoxItem25��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $Z�TІнформація про державне соціалье страхування���� -   $ ListBoxItem26��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $E�?Інформація про освіту працівників���� -   $ ListBoxItem27��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $I�CІнформація про післядипломну освіту���� -   $ ListBoxItem28��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $0�*Загальний список посад���� -   $ ListBoxItem29��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $3�-Список посад (з окладами)���� -   $ ListBoxItem30��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $)�#Список підрозділів���� -    $ ListBoxItem31��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $6�0Інформація про підрозділи���� -!   $ ListBoxItem32��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $>�8Список працівників та їх посад���� -"   $ ListBoxItem33��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $<�6Список працюючих працівників���� -#   $ ListBoxItem34��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $_�YПрацівники, які проходять випробувальний термін���� -$   $ ListBoxItem35��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $@�:Працівники, яких було звільнено���� -%   $ ListBoxItem37��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $5�/Працівники та їхні оклади���� -&   $ ListBoxItem38��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $Z�TСписок особових карток працюючих працівників���� -'   $ ListBoxItem39��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $S�MПрисутність на роботі працівників (за рік)���� -(   $ ListBoxItem40��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $=�7Лікарняні працівників (за рік)���� -)   $ ListBoxItem41��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $=�7Відпустки працівників (за рік)���� -*   $ ListBoxItem42��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $A�;Відсутність працівників (за рік)���� -+   $ ListBoxItem43��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $Y�SДіяльність працівників за рік (зведений звіт)���� -,   $ ListBoxItem44��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $h�bДіяльність працівників за всі періоди (зведений звіт)���� --   $ ListBoxItem45��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $0�*Список трудових книжок���� -.   $ ListBoxItem46��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $K�EІнформація про відпустки працівників���� -/   $ ListBoxItem47��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $!�Штатний розпис���� -0   $ ListBoxItem48��.���� $ 
Horizontal=�.+��� $��Images/report2.png���� �� $�Штатна книга��+  %Telerik.ReportViewer.Wpf.ReportViewer  -1     Name$ ReportViewer��$��293,10,10,10q�