   M S B A M L   `   `   `  ����@  <Store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Store.PageLogInStore.PageLogIn  5      "    Store.PageLogIn.Registration   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Store.PageLogIn     5        N� Title$  Registration��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��347* �6   �� 5      $
��102* �6   .+�5   
   �� $��Bottom=�6   $	��300��6/   �� 5   
    �� Orientation$ Vertical=�6   $��Center=�6,   $��Center=�5      $	��307��62   $	��400��6?   .+�5      �� -   5         ��Name$ logReg��5      
 � Tag$ Логин...��5      $��0 20 0 0q�6%   
������ $��2q�6P   ��5   &   �� *logIn+5   P   �� 5      -   5        $��tryPass��5      $
��qwor��6#   $y�	Collapsed=�62   
���  ��$��15(�5   %   $��35��64   $	��300��6@   $
��Left=�5      $��60 0 0 0q�6/   �� 5      -   5        $ passReg��5      $ Пароль...��6=   $��0 20 0 0q�5      
������ $��2q�6A   ��5   '   �� *pass+5   A   �� 5      -   5        $ firstNameReg��5      $ 	Имя...��6G   $��0 20 0 0q�5      
������ $��2q�6A   ��5   ,   �� *	firstName+5   A   �� 5      -   5        $ lastNameReg��5      $ Фамилия...��6E   $��0 20 0 0q�5      
������ $��2q�6A   ��5   +   �� *
lastName+5   A   5      �� 5   
   $��1��6   $ 
Horizontal=�6"   $��Center=�6;   $��Center=�5       $��50��60   .+�5!      �� -   5         ��Name$ btnOk��5!   "   $
��Ок��6   $��Center=�61   $��Center=�5"      60   �� 5#      -   5        $ btnLog��5#   %   $��
Войти��6   $��Center=�65   $��Center=�5$      60   5%      5&      5'      