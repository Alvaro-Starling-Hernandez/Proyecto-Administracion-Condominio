   M S B A M L   `   `   `  ����M  IProyectoCondominio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:ProyectoCondominio.UI.RegistrosProyectoCondominio.UI.Registros  5   	   8    2ProyectoCondominio.UI.Registros.rCambiarContrasena   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:ProyectoCondominio.UI.Registros     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	     MaterialDesignPaper#���  5
   	   $��Regular"�5   	   $��14(�5   	     � Title$  Cambiar Contraseña��5   	   $	��350��6$   $	��300��61    � WindowStartupLocation$ CenterScreen=�6=    � 
ResizeMode$ CanMinimize=�6b   ��5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��10,0,0,0q�6,   .+�5      �� $ Vertical=�6   $
��0,10q�60   .+�5      �� $��0,5,10,0q�6   $
��Left=�6/   .+�5      �� $��Contraseña Actual:��6   G� 5      -   5         G�Name$ ContrasenaPasswordBox��5   "   $	��260��6A   5      �� 5      $��	0,10,10,0q�6   $
��Left=�60   .+�5      �� $��Nueva Contraseña:��6   G� 5      -   5        $ NuevaPasswordBox��5   "   $	��260��6<   5      �� 5      $��	0,10,10,0q�6   $
��Left=�60   .+�5      �� $��Confirmar Contraseña:��6   G� 5      -   5        $ ConfirmarPasswordBox��5   "   $	��260��6@   5       5!      �� 5$      $ 
Horizontal=�6   $
��5,35q�62   $
��Left=�6@   .+�5%      �� -   5         ��Name$ AceptarButton��5%      .��5&      �� $ 
Horizontal=�6!   .+�5'      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Done=�62   $��25��6>   $��25��6I   �� 5(      $��Aceptar��6    $
��Bold"�62   
�������6D   5)      5*      �� 5,      -   5        $ CancelarButton��5,      $
��20,0q�61   .��5-      �� $ 
Horizontal=�6!   .+�5.        $ Cancel=�62   $��25��6A   $��25��6L   �� 5/      $��Cancelar��6    $
��Bold"�63   
�������6E   50      51      52      53      54      55      