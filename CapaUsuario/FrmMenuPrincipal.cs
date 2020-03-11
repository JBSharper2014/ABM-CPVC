
using CapaDatos;
using CapaUsuario.Cobros;
using CapaUsuario.Compras;
using CapaUsuario.Compras.Bienes_de_uso;
using CapaUsuario.Compras.Cuenta_corriente;
using CapaUsuario.Compras.Factura_prov;
using CapaUsuario.Compras.Informe_recepcion;
using CapaUsuario.Compras.Nota_credito;
using CapaUsuario.Compras.Orden_de_Compra;
using CapaUsuario.Compras.Pedido_dev;
using CapaUsuario.Compras.Pedidos_de_reaprovisionamiento;
using CapaUsuario.Compras.Proveedores;
using CapaUsuario.Compras.Registracion;
using CapaUsuario.Compras.Solicitud_de_compra;
using CapaUsuario.Cotizaciones;
using CapaUsuario.Pagos.Cuenta_bancaria_empresa;
using CapaUsuario.Pagos.Orden_pago;
using CapaUsuario.Pagos.Registracion_debito;
using CapaUsuario.Ventas.Clientes;
using CapaUsuario.Ventas.Devolucion;
using CapaUsuario.Ventas.Factura_venta;
using CapaUsuario.Ventas.Nota_credito;
using CapaUsuario.Ventas.Pedido_de_venta;
using CapaUsuario.Ventas.Precios;
using CapaUsuario.Ventas.Registracion_monetaria;
using CapaUsuario.Ventas.Remito_venta;
using System;
using System.Drawing;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace CapaUsuario
{
    public partial class FrmMenuPrincipal : Form
    {
        private DUsuario usuarioLogueado;

        private DEmpleado empleado;

        public DUsuario UsuarioLogueado { get => usuarioLogueado; set => usuarioLogueado = value; }

        Timer t1 = new Timer();

        private FrmBienUso bienesDeUso;
        private FrmStock stock;
        private FrmProveedores proveedores;
        private SolicitudCompra solicitudDeCompra;
        private FrmPedidosReaprov frmPedidosReaprov;
        private FrmCotizaciones frmCotizaciones;
        private FrmOrdenDeCompra frmOrdenDeCompra;
        private FrmClientes frmClientes;
        private FrmListaPrecios frmListaPrecios;
        private FrmPedidoVenta frmPedidoVenta;
        private FrmRemitoVenta frmRemitoVenta;
        private FrmFacturaVenta frmFacturaVenta;
        private FrmPedidoDevolucion frmPedidoDevolucion;
        private FrmNotaCredito frmNotaCredito;
        private Ventas.Registracion_monetaria.FrmRegistracionMonetaria frmRegistracionMonetaria;
        private FrmConfirmacionCobro frmConfirmacionCobro;
        private Cobros.FrmRegistracionMonetaria frmRegistracionMonetariaCobros;
        private FrmOrdenPago frmOrdenPago;
        private FrmCuentaBancaria frmCuentaBancaria;
        private FrmRegistracionDebito frmRegistracionDebito;
        private FrmFacurasProv frmFacurasProv;
        private FrmInformeRecepcion frmInformeRecepcion;
        private FrmCuentasCorriente frmCuentasCorriente;
        private FrmPedidoDev frmPedidoDev;
        private FrmNotaCreditoCompras frmNotaCreditoCompras;
        private FrmRegistracion frmRegistracion;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
           

            Opacity = 0;      //first the opacity is 0
           
            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
        }

        private void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stock == null || stock.IsDisposed)
            {
                stock = new FrmStock
                {
                    MdiParent = this,
                    //UsuarioLogueado = usuarioLogueado
                };
                stock.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            DEmpleado dEmpleado = new DEmpleado();

            empleado = dEmpleado.GetNombreCompletoEmpleadoByCodEmpleado(usuarioLogueado.CodEmpleado);

            var popup = new PopupNotifier()
            {
                Image = Properties.Resources.data_Inserted,
                TitleText = "Mensaje",
                ContentText = $"Conexión exitosa. Bienvenido, {empleado.Nombre} {empleado.Apellido}",
                ContentFont = new Font("Segoe UI Bold", 11F),
                TitleFont = new Font("Segoe UI Bold", 11F)
            };
            popup.Popup();

            //mostramos en la barra de status el usuario actual usando la aplicación
            NombresUsuarioToolStripStatusLabel.Text = $"Usuario actual: {empleado.Nombre} {empleado.Apellido}";
        }

        private void bienesDeUsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bienesDeUso == null || bienesDeUso.IsDisposed)
            {
                bienesDeUso = new FrmBienUso
                {
                    MdiParent = this,
                    //UsuarioLogueado = usuarioLogueado
                };
                bienesDeUso.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Salir del programa?", "Confirmación",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;
            else
            {
                Close();
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proveedores == null || proveedores.IsDisposed)
            {
                proveedores = new FrmProveedores
                {
                    MdiParent = this,
                    //UsuarioLogueado = usuarioLogueado
                };
                proveedores.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void solicitudesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (solicitudDeCompra == null || solicitudDeCompra.IsDisposed)
            {
                solicitudDeCompra = new SolicitudCompra
                {
                    MdiParent = this,
                    //UsuarioLogueado = usuarioLogueado
                };
                solicitudDeCompra.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void pedidosDeReaprovisionamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPedidosReaprov == null || frmPedidosReaprov.IsDisposed)
            {
                frmPedidosReaprov = new FrmPedidosReaprov
                {
                    MdiParent = this,
                    //UsuarioLogueado = usuarioLogueado
                };
                frmPedidosReaprov.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCotizaciones == null || frmCotizaciones.IsDisposed)
            {
                frmCotizaciones = new FrmCotizaciones
                {
                    MdiParent = this,
                    //UsuarioLogueado = usuarioLogueado
                };
                frmCotizaciones.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void órdenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmOrdenDeCompra == null || frmOrdenDeCompra.IsDisposed)
            {
                frmOrdenDeCompra = new FrmOrdenDeCompra
                {
                    MdiParent = this,
                    //UsuarioLogueado = usuarioLogueado
                };
                frmOrdenDeCompra.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmClientes == null || frmClientes.IsDisposed)
            {
                frmClientes = new FrmClientes
                {
                    MdiParent = this,
                    //UsuarioLogueado = usuarioLogueado
                };
                frmClientes.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void listaDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmListaPrecios == null || frmListaPrecios.IsDisposed)
            {
                frmListaPrecios = new FrmListaPrecios
                {
                    MdiParent = this
                    //UsuarioLogueado = usuarioLogueado
                };
                frmListaPrecios.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void pedidosDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPedidoVenta == null || frmPedidoVenta.IsDisposed)
            {
                frmPedidoVenta = new FrmPedidoVenta
                {
                    MdiParent = this
                    //UsuarioLogueado = usuarioLogueado
                };
                frmPedidoVenta.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void remitosDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRemitoVenta == null || frmRemitoVenta.IsDisposed)
            {
                frmRemitoVenta = new FrmRemitoVenta
                {
                    MdiParent = this
                    //UsuarioLogueado = usuarioLogueado
                };
                frmRemitoVenta.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void facturasDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmFacturaVenta == null || frmFacturaVenta.IsDisposed)
            {
                frmFacturaVenta = new FrmFacturaVenta
                {
                    MdiParent = this
                    //UsuarioLogueado = usuarioLogueado
                };
                frmFacturaVenta.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void pedidosDeDevoluciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmPedidoDevolucion == null || frmPedidoDevolucion.IsDisposed)
            {
                frmPedidoDevolucion = new FrmPedidoDevolucion
                {
                    MdiParent = this
                    //UsuarioLogueado = usuarioLogueado
                };
                frmPedidoDevolucion.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void notasDeCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmNotaCredito == null || frmNotaCredito.IsDisposed)
            {
                frmNotaCredito = new FrmNotaCredito
                {
                    MdiParent = this
                    //UsuarioLogueado = usuarioLogueado
                };
                frmNotaCredito.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void registraciónMonetariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRegistracionMonetaria == null || frmRegistracionMonetaria.IsDisposed)
            {
                frmRegistracionMonetaria = new Ventas.Registracion_monetaria.FrmRegistracionMonetaria
                {
                    MdiParent = this
                    //UsuarioLogueado = usuarioLogueado
                };
                frmRegistracionMonetaria.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void confirmacionesDeCobroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmConfirmacionCobro == null || frmConfirmacionCobro.IsDisposed)
            {
                frmConfirmacionCobro = new FrmConfirmacionCobro
                {
                    MdiParent = this
                    //UsuarioLogueado = usuarioLogueado
                };
                frmConfirmacionCobro.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void registraciónMonetariaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmRegistracionMonetariaCobros == null || frmRegistracionMonetariaCobros.IsDisposed)
            {
                frmRegistracionMonetariaCobros = new Cobros.FrmRegistracionMonetaria
                {
                    MdiParent = this
                    //UsuarioLogueado = usuarioLogueado
                };
                frmRegistracionMonetariaCobros.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void órdenesDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmOrdenPago == null || frmOrdenPago.IsDisposed)
            {
                frmOrdenPago = new FrmOrdenPago
                {
                    MdiParent = this
                    //UsuarioLogueado = usuarioLogueado
                };
                frmOrdenPago.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void cuentaBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCuentaBancaria == null || frmCuentaBancaria.IsDisposed)
            {
                frmCuentaBancaria = new FrmCuentaBancaria
                {
                    MdiParent = this
                    //UsuarioLogueado = usuarioLogueado
                };
                frmCuentaBancaria.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void registracionesDeDébitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRegistracionDebito == null || frmRegistracionDebito.IsDisposed)
            {
                frmRegistracionDebito = new FrmRegistracionDebito
                {
                    MdiParent = this
                    //UsuarioLogueado = usuarioLogueado
                };
                frmRegistracionDebito.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void facturaProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmFacurasProv == null || frmFacurasProv.IsDisposed)
            {
                frmFacurasProv = new FrmFacurasProv
                {
                    MdiParent = this
                    //UsuarioLogueado = usuarioLogueado
                };
                frmFacurasProv.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void informeRecepciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmInformeRecepcion == null || frmInformeRecepcion.IsDisposed)
            {
                frmInformeRecepcion = new FrmInformeRecepcion
                {
                    MdiParent = this
                    //UsuarioLogueado = usuarioLogueado
                };
                frmInformeRecepcion.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void cuentaCorrienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCuentasCorriente == null || frmCuentasCorriente.IsDisposed)
            {
                frmCuentasCorriente = new FrmCuentasCorriente()
                {
                    MdiParent = this
                    //UsuarioLogueado = usuarioLogueado
                };
                frmCuentasCorriente.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void pedidosDeDevoluciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPedidoDev == null || frmPedidoDev.IsDisposed)
            {
                frmPedidoDev = new FrmPedidoDev()
                {
                    MdiParent = this
                    //UsuarioLogueado = usuarioLogueado
                };
                frmPedidoDev.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void notaDeCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmNotaCreditoCompras == null || frmNotaCreditoCompras.IsDisposed)
            {
                frmNotaCreditoCompras = new FrmNotaCreditoCompras()
                {
                    MdiParent = this
                    //UsuarioLogueado = usuarioLogueado
                };
                frmNotaCreditoCompras.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void registraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRegistracion == null || frmRegistracion.IsDisposed)
            {
                frmRegistracion = new FrmRegistracion()
                {
                    MdiParent = this
                    //UsuarioLogueado = usuarioLogueado
                };
                frmRegistracion.Show();
            }
            else
            {
                MessageBox.Show("El formulario ya se encuentra abierto", "Atención",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
