   M S B A M L   `   `   `  ����@  <Store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Store.PageProductStore.PageProduct  5          Store.PageProduct.AddPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Store.PageProduct     5        N� Title$  AddPage��5	       � 	Resources 5
       �� 
TargetType   styleComboBox �� Property �� Value��%Z   &	        �� 5   
   " ��6   .�5      ��  � �� �	#FF3669E06+   5      5      .��5      � ��6   �� *	stylePage+ � RowDefinitions 5   
   �� 5      $
��347* �6   �� 5      $
��102* �6   .+�5   
   �� $��Bottom=�6   $	��300��6/   �� 5   
   $��Наименование��6   
�������$��	90 35 0 0q�6>   $��20(�6Q   �� 5   
   $��Стоимость��6   
�������$��135 155 0 0q�6;   $��20(�6P   �� 5   
   $��Количество��6   
�������$��130 215 0 0q�6<   $��20(�6Q   �� 5   
   $��дд/ММ/гггг��6   
�������$��130 275 0 0q�6<   $��20(�6Q   �� 5   
    �� Orientation$ Vertical=�6   $��Center=�6,   $��Center=�6G   $	��350��6d   $��0 20 0 0q�6q   $	��400��6�   .+�5      �� -   5         ��Name$ NameProd��5      
 � Tag$ name product...��6B   $��0 20 0 0q�6X   
������ $��2q�6�   ��6(   �� *
nameProd+6�   �� 5      -   5        	 ��Name$	 comboBox��5      $��20(�6)   $��50��68   $��0 10 0 0q�6D   
 �� DisplayMemberPath$
 typeProduct��6{   $	��300��6�    �� SelectedItem 6V   �� *typeProduct+5      �� 5      -   5        $ Price��5      $ price...��6<   $��0 10 0 0q�6L   
������ $��2q�6w   ��6%   �� *price+6w   �� 5      -   5        $ Quantity��5      $ quantity��6B   $��0 10 0 0q�6R   
������ $��2q�6}   ��6(   �� *
quantity+6}   �� 5      -   5        $ _DeliveryDate��5      $" delivery date day/month/year��5!      $��0 10 0 0q�6:   
������ $��2q�6e   ��5   -   �� *deliveryDate+ �� StringFormat$ {0:dd/MM/yyyy}�� �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�5!   e   5"      �� 5#   
   $��1��6   $ 
Horizontal=�6"   $��Center=�6;   $��Center=�6X   $��50��6s   $	��300��6   .+�5$      �� -   5         ��Name$ btnAply��5$   '   $��Принять��6   $��Center=�68   $��Center=�6U   6p   �� 5%      -   5        $ 	btnCancel��5%   &   $��Отмена��6   $��Center=�69   $��Center=�6V   6q   5&      5'      5(      