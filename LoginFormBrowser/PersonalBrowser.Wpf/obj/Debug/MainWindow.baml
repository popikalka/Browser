   M S B A M L   `   `   `  ����N  JPersonalBrowser.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:PersonalBrowser.Wpf.ViewModelPersonalBrowser.Wpf.ViewModel  5   	   G(clr-namespace:PersonalBrowser.Wpf.HelperPersonalBrowser.Wpf.Helper  5   	   $    PersonalBrowser.Wpf.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   A	viewModel+clr-namespace:PersonalBrowser.Wpf.ViewModel     5   	   <browser(clr-namespace:PersonalBrowser.Wpf.Helper     5   	     � Title$-  'Персональный браузер��5
   	   $	��350��6&   $	��525��63   $��16(�6?   .��5      � $��5q�6    � ColumnDefinitions 5   
   �� 5      $	��140 �6   �� 5      $��25 �6   �� 5      $��25 �6   �� 5      $��25 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��25 �6   �� 5      $��30 �6   �� 5      $��40 �6   �� 5      $��* �6   .+�5   
   o� $��12(�6   $��Center=�6   .@�5      m� $��Программа��6   .@�5      m� -   5        $��
Выйти��5      6?   �� 5      6   m� 5      -   5        $��Закрыть��5      6?   5      m� 5      $��Ссылки��6   .@�5       m� -   5        $��Добавить��5       6-   m� 5!      -   5        $��Изменить��5!      6-   �� 5"      m� 5#      -   5        $��Удалить��5#      6,   5$      5%      �� 5&   
   $��0��5'      $��1��5(      $	��5,0q�5)       �� TextAlignment$ Center=�5*      ��5+      �� *
UserName+ �� Mode$ TwoWay=��� 5,   
   -   5        $��0��5-      $��2��5.      $��5q�5/      .��50   $   Загрузить52      �� 53   
   -   5        $��	ListLinks��54      $��0��55      $��3��56       �� SelectionMode$ Single=�57         ListViewStyle#��[  5:      ��5;      �� *Links+  ListConverter �� 	Converter# [ $ TwoWay=��� 5<   
   -   5        $
��Prev��5=      $��1��5>      $��0��5?      $��2q�5@      $	��Top=�5B      $
��Left=�5C      ��5D      �� 5E      .R�5F      ��  �� Orientation$ 
Horizontal=�6!   .+�5G      �� $3��-/PersonalBrowser.Wpf;component/Icons/Left.png��6    $��0q�6W   5H      5I      5K      �� 5L   
   -	   5        $
��Next��5M      $��2��5N      $��0��5O      $��2q�5P      ��5R      �� 5S      .R�5T      �� $ 
Horizontal=�6!   .+�5U      �� $4��./PersonalBrowser.Wpf;component/Icons/Right.png��6    $��0q�6X   5V      5W      5Y      �� 5Z   
   -
   5        $��3��5[      $��0��5\      $��2q�5]      ��5_      �� 5`      .R�5a      �� $ 
Horizontal=�6!   .+�5b      �� $5��//PersonalBrowser.Wpf;component/Icons/Replay.png��6    $��0q�6Y   5c      5d      5f      �� 5g   
   -   5        $��UrlBox��5i      $��4��5k      $��0��5l      $��11(�5m      $��2q�5n      ��5h      �� *CurrentSite+  UrlConverter# [ $ TwoWay=�5n      (  "System.Windows.Controls.WebBrowser  5o   
   -   5        $��Browser��5t      $��1��5p      $��1��5q      $��4��5r      $��3��5s      2   ,PersonalBrowser.Wpf.Helper.WebBrowserUtility   BindableSource 5o      �� *CurrentSite+# [ $ TwoWay=�5t      5u      5v      