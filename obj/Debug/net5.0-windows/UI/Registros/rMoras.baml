   M S B A M L   `   `   `  ����M  IProyectoCondominio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:ProyectoCondominio.UI.RegistrosProyectoCondominio.UI.Registros  5   	   ,    &ProyectoCondominio.UI.Registros.rMoras   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:ProyectoCondominio.UI.Registros     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	     MaterialDesignPaper#���  5
   	   $��Regular"�5   	   $��14(�5   	     � Title$  Registro de Mora��5   	   $	��230��6"   $	��420��6/    � WindowStartupLocation$ CenterScreen=�6;    � 
ResizeMode$ CanMinimize=�6`   ��5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��10,0,0,0q�6,   .+�5      �� $ Vertical=�6   $
��0,10q�60   .+�5      �� $��Mora Id:��6   �� 5      $ 
Horizontal=�6   .+�5      �� -   5         ��Name$ IdMoraTextBox��5      $	��100��6M   $��23��6Y   $��5,0,0,0q�6e   ��65   �� *MoraId+6v   �� 5      -   5         ��Name$ BuscarButton��5      $
��35,0q�64   .��5      �� $ 
Horizontal=�6%   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�66   $��25��6D   $��25��6O   �� 5      $��Buscar��6$   $
��Bold"�65   
�������6G   5      5      5      �� 5      $��0,0,10,0q�6   $
��Left=�6/   .+�5      �� $��
Porciento:��6   �� 5       -   5        $ PorcientoTextBox��5        �� 	MaxLength$ 4��68   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ No debe ingresar ¨%¨��6F   $	��350��6�   $��5,0,0,0q�6�   ��6|   �� *	Porciento+6�   5!      5#      �� 5&      $ 
Horizontal=�6   $
��5,15q�62   $
��Left=�6@   .+�5'      �� -   5        $ NuevoButton��5'      .��5(      �� $ 
Horizontal=�6!   .+�5)        $ NewspaperPlus=�62   $��25��6G   $��25��6R   �� 5*      $��Nuevo��6    $
��Bold"�60   
�������6B   5+      5,      �� 5.      -   5        $ GuardarButton��5.      $
��20,0q�60   .��5/      �� $ 
Horizontal=�6!   .+�50        $ ContentSave=�62   $��25��6F   $��25��6Q   �� 51      $��Guardar��6    $
��Bold"�62   
�������6D   52      53      �� 55      -   5        $ EliminarButton��55      .��56      �� $ 
Horizontal=�6!   .+�57        $ DeleteForever=�62   $��25��6G   $��25��6R   �� 58      $��Eliminar��6    $
��Bold"�63   
�������6E   59      5:      5;      5<      5=      5>      