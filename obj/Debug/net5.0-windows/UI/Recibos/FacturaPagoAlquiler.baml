   M S B A M L   `   `   `  ����M  IProyectoCondominio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:ProyectoCondominio.UI.RecibosProyectoCondominio.UI.Recibos  5   	   7    1ProyectoCondominio.UI.Recibos.FacturaPagoAlquiler   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:ProyectoCondominio.UI.Recibos     5   	   _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	     MaterialDesignPaper#���  5
   	   $��Regular"�5   	   $��16(�5   	     � Title$  Factura Pago Alquiler��5   	   $	��700��6'   $��793.92��64    � WindowStyle$
 None=�6C    � 
ResizeMode$ NoResize=�6V   ��5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      � -   5         �Name$ print��5      .+�5   
   �� $��30q�6   .+�5      �� $
��0,20q�6    �� Orientation$ 
Horizontal=�6'   .+�5      �� $��Recibo de Alquiler��6   $
��Bold"�65   $��30(�6G   �� 5      $ Vertical=�6   $��240,0q�64   $	��255��6C   .+�5      �� $ 
Horizontal=�6!   .+�5      �� $��Fecha Pago:��6    $��Medium"�66   �� 5      -   5         ��Name$ FechaPagoLabel��5       $��Fecha��68   $��45,0,0,0q�6H   5      �� 5      $ 
Horizontal=�6!   .+�5      �� $��Codigo Alquiler:��6    $��Medium"�6;   �� 5      -   5        $ CodigoLabel��5       $��Codigo��65   $��20,0,0,0q�6F   5      5      5      �� 5!      	 �� X1$ 0��6   	 �� X2$ 763.92��6   	 �� Y1$ 1��6&   		 �� Y2$	 1��6-   
���   �$��2��6C   �� 5#      $
��0,20q�6   $ Vertical=�6'   .+�5$      �� $��Datos del Propietario:��6   $
��Bold"�69   $��20(�6K   $��0,0,0,10q�6Y   �� 5%      $ 
Horizontal=�6   .+�5&      �� $��Nombre Completo:��6   $��Medium"�67   �� 5'      -   5        $ NombreCompletoLabel��5'      $��Nombre��69   $��40,0,0,0q�6J   5(      �� 5*      $ 
Horizontal=�6   .+�5+      �� $��Tipo de documento:��6   $��Medium"�69   �� 5,      -   5        $ TipoDocuemntoLabel��5,      $��TipoDocuemnto��68   $��33,0,0,0q�6P   5-      �� 5/      $ 
Horizontal=�6   .+�50      �� $��No. Documento:��6   $��Medium"�65   �� 51      -   5        $ DocuemntoLabel��51      $��	Documento��64   $��58,0,0,0q�6H   52      55      �� 57      $ 0��6   $ 763.92��6   $ 1��6&   $	 1��6-   
���   �$��2��6C   �� 59      $
��0,20q�6   $ Vertical=�6'   .+�5:      �� $��Por el Alquiler de:��6   $
��Bold"�66   $��20(�6H   $��0,0,0,10q�6V   �� 5;      $ 
Horizontal=�6   .+�5<      �� $��Codigo Inmueble:��6   $��Medium"�67   �� 5=      -   5        $ CodigoImuebleLabel��5=      $��Codio��68   $��46,0,0,0q�6H   5>      �� 5@      $ 
Horizontal=�6   .+�5A      �� $��Descripcion:��6   $��Medium"�63   �� 5B      -   5        $ DescripcionLabel��5B      $��Descripcion��66   $��80,0,0,0q�6L   5C      �� 5E      $ 
Horizontal=�6   .+�5F      �� $��Tipo Inmueble:��6   $��Medium"�65   �� 5G      -	   5        $ TipoInmuebleLael��5G      $
��Tipo��66   $��63,0,0,0q�6E   5H      5K      �� 5M      $ 0��6   $ 763.92��6   $ 1��6&   $	 1��6-   
���   �$��2��6C   �� 5O      $
��0,20q�6   $ Vertical=�6'   .+�5P      �� $��Datos del Inquilino:��6   $
��Bold"�67   $��20(�6I   $��0,0,0,10q�6W   �� 5R      $ 
Horizontal=�6   .+�5S      �� $��Nombre Completo:��6   $��Medium"�67   �� 5T      -
   5        $" NombreCompletoInquilinoLabel��5T      $��Nombre��6B   $��40,0,0,0q�6S   5U      �� 5W      $ 
Horizontal=�6   .+�5X      �� $��Tipo de documento:��6   $��Medium"�69   �� 5Y      -   5        $! TipoDocuemntoInquilinoLabel��5Y      $��TipoDocuemnto��6A   $��33,0,0,0q�6Y   5Z      �� 5\      $ 
Horizontal=�6   .+�5]      �� $��No. Documento:��6   $��Medium"�65   �� 5^      -   5        $ DocuemntoInquilinoLabel��5^      $��	Documento��6=   $��59,0,0,0q�6Q   5_      5a      �� 5c      $ 0��6   $ 763.92��6   $ 1��6&   $	 1��6-   
���   �$��2��6C   �� 5e      $
��0,20q�6   $ Vertical=�6'   .+�5f      �� $ 
Horizontal=�6   .+�5g      �� $��Por el periodo # :��6   $��Medium"�69   �� 5h      -   5        $ NumeroPeriodo��5h      $��Numero��63   $��53,0,0,0q�6D   5i      �� 5j      $ 
Horizontal=�6   .+�5k      �� $��Importe Pagado:��6   $��Medium"�66   �� 5l      -   5        $ ImportePagado��5l      $��Importe��63   $��55,0,0,0q�6E   5m      5n      5p      5r      5s      