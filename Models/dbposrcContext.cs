using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SoftWarePos.Models
{
    public partial class dbposrcContext : DbContext
    {
        public dbposrcContext()
        {
        }

        public dbposrcContext(DbContextOptions<dbposrcContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; } = null!;
        public virtual DbSet<TBodega> TBodegas { get; set; } = null!;
        public virtual DbSet<TCliente> TClientes { get; set; } = null!;
        public virtual DbSet<TClientesCta> TClientesCtas { get; set; } = null!;
        public virtual DbSet<TCuenta> TCuentas { get; set; } = null!;
        public virtual DbSet<TCuentasProducto> TCuentasProductos { get; set; } = null!;
        public virtual DbSet<TFormasPago> TFormasPagos { get; set; } = null!;
        public virtual DbSet<TGrupo> TGrupos { get; set; } = null!;
        public virtual DbSet<TInventario> TInventarios { get; set; } = null!;
        public virtual DbSet<TInventarioMov> TInventarioMovs { get; set; } = null!;
        public virtual DbSet<TMesa> TMesas { get; set; } = null!;
        public virtual DbSet<TMesero> TMeseros { get; set; } = null!;
        public virtual DbSet<TOpcionesBebida> TOpcionesBebidas { get; set; } = null!;
        public virtual DbSet<TOpcionesEndulzar> TOpcionesEndulzars { get; set; } = null!;
        public virtual DbSet<TOpcionesTermino> TOpcionesTerminos { get; set; } = null!;
        public virtual DbSet<TOpcionesTono> TOpcionesTonos { get; set; } = null!;
        public virtual DbSet<TParametro> TParametros { get; set; } = null!;
        public virtual DbSet<TProducto> TProductos { get; set; } = null!;
        public virtual DbSet<TProductosBebida> TProductosBebidas { get; set; } = null!;
        public virtual DbSet<TPwd> TPwds { get; set; } = null!;
        public virtual DbSet<TRecibo> TRecibos { get; set; } = null!;
        public virtual DbSet<TReporte> TReportes { get; set; } = null!;
        public virtual DbSet<TResolucion> TResolucions { get; set; } = null!;
        public virtual DbSet<TTiposPago> TTiposPagos { get; set; } = null!;
        public virtual DbSet<TUsuario> TUsuarios { get; set; } = null!;

//         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         {
//             if (!optionsBuilder.IsConfigured)
//             {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                 optionsBuilder.UseMySql("server=127.0.0.1;port=3306;user=root;password=Montufar.16;database=dbposrc", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));
//             }
//         }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ProductVersion).HasMaxLength(32);
            });

            modelBuilder.Entity<TBodega>(entity =>
            {
                entity.HasKey(e => e.IdBod)
                    .HasName("PRIMARY");

                entity.ToTable("t_bodegas");

                entity.HasComment("Bodegas para los productos")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.IdBod).HasColumnName("Id_Bod");

                entity.Property(e => e.NomBod)
                    .HasMaxLength(60)
                    .HasColumnName("Nom_Bod");
            });

            modelBuilder.Entity<TCliente>(entity =>
            {
                entity.HasKey(e => e.IdCli)
                    .HasName("PRIMARY");

                entity.ToTable("t_clientes");

                entity.HasComment("Clientes del Restaurante")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.IdCli).HasColumnName("Id_Cli");

                entity.Property(e => e.ApeCli)
                    .HasMaxLength(50)
                    .HasColumnName("Ape_Cli");

                entity.Property(e => e.CelCli)
                    .HasMaxLength(20)
                    .HasColumnName("Cel_Cli");

                entity.Property(e => e.CiudCli)
                    .HasMaxLength(100)
                    .HasColumnName("Ciud_Cli");

                entity.Property(e => e.DirCli)
                    .HasMaxLength(100)
                    .HasColumnName("Dir_Cli");

                entity.Property(e => e.MailCli)
                    .HasMaxLength(50)
                    .HasColumnName("Mail_Cli");

                entity.Property(e => e.NomCli)
                    .HasMaxLength(50)
                    .HasColumnName("Nom_Cli");

                entity.Property(e => e.NumIdCli)
                    .HasMaxLength(20)
                    .HasColumnName("Num_Id_Cli");

                entity.Property(e => e.ObservCli)
                    .HasMaxLength(255)
                    .HasColumnName("Observ_Cli");

                entity.Property(e => e.PaisCli)
                    .HasMaxLength(100)
                    .HasColumnName("Pais_Cli");

                entity.Property(e => e.TipoCli)
                    .HasMaxLength(1)
                    .HasColumnName("Tipo_cli")
                    .HasDefaultValueSql("'N'");
            });

            modelBuilder.Entity<TClientesCta>(entity =>
            {
                entity.HasKey(e => e.IdCliCta)
                    .HasName("PRIMARY");

                entity.ToTable("t_clientes_ctas");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.IdCliCta).HasColumnName("Id_Cli_Cta");

                entity.Property(e => e.Control)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.FechaCta)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Cta");

                entity.Property(e => e.FechaPago)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Pago");

                entity.Property(e => e.IdCli).HasColumnName("Id_Cli");

                entity.Property(e => e.IdCta).HasColumnName("Id_Cta");

                entity.Property(e => e.NumCom)
                    .HasMaxLength(20)
                    .HasColumnName("Num_Com");

                entity.Property(e => e.NumFact)
                    .HasMaxLength(20)
                    .HasColumnName("Num_Fact");

                entity.Property(e => e.NumRbo).HasColumnName("Num_Rbo");

                entity.Property(e => e.VrTot).HasColumnName("Vr_Tot");
            });

            modelBuilder.Entity<TCuenta>(entity =>
            {
                entity.HasKey(e => e.IdCta)
                    .HasName("PRIMARY");

                entity.ToTable("t_cuentas");

                entity.HasComment("Pedidos de la mesa")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.IdCta).HasColumnName("Id_Cta");

                entity.Property(e => e.Bloqueo)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Cancela)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Clase).HasMaxLength(1);

                entity.Property(e => e.FechaBloq)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Bloq");

                entity.Property(e => e.FechaCta)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Cta");

                entity.Property(e => e.IdCli).HasColumnName("Id_Cli");

                entity.Property(e => e.IdFormaPago)
                    .HasColumnName("Id_Forma_Pago")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdMesa).HasColumnName("Id_Mesa");

                entity.Property(e => e.IdMese).HasColumnName("Id_Mese");

                entity.Property(e => e.IdResol).HasColumnName("Id_Resol");

                entity.Property(e => e.IdTipoPago)
                    .HasColumnName("Id_Tipo_Pago")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ImpreIpc)
                    .HasMaxLength(1)
                    .HasColumnName("impre_ipc")
                    .HasDefaultValueSql("'S'");

                entity.Property(e => e.Impresa)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.NumCom)
                    .HasMaxLength(20)
                    .HasColumnName("Num_Com");

                entity.Property(e => e.NumFact)
                    .HasMaxLength(20)
                    .HasColumnName("Num_Fact");

                entity.Property(e => e.VrCamb)
                    .HasColumnName("Vr_Camb")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VrEnt)
                    .HasColumnName("Vr_Ent")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VrTot)
                    .HasColumnName("Vr_Tot")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TCuentasProducto>(entity =>
            {
                entity.ToTable("t_cuentas_productos");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.IdProd, "Index_2");

                entity.Property(e => e.Despacho).HasMaxLength(1);

                entity.Property(e => e.FechaDesp)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Desp");

                entity.Property(e => e.IdCta).HasColumnName("Id_Cta");

                entity.Property(e => e.IdOpEnd).HasColumnName("Id_Op_End");

                entity.Property(e => e.IdOpTer).HasColumnName("Id_Op_Ter");

                entity.Property(e => e.IdOpTon).HasColumnName("Id_Op_Ton");

                entity.Property(e => e.IdProd).HasColumnName("Id_Prod");

                entity.Property(e => e.NomProd)
                    .HasMaxLength(150)
                    .HasColumnName("nom_prod");

                entity.Property(e => e.OpLlevar)
                    .HasMaxLength(1)
                    .HasColumnName("Op_Llevar")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Precio).HasDefaultValueSql("'0'");

                entity.Property(e => e.VerFact)
                    .HasMaxLength(1)
                    .HasColumnName("Ver_Fact")
                    .HasDefaultValueSql("'S'");

                entity.HasOne(d => d.IdProdNavigation)
                    .WithMany(p => p.TCuentasProductos)
                    .HasForeignKey(d => d.IdProd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_id_prod");
            });

            modelBuilder.Entity<TFormasPago>(entity =>
            {
                entity.HasKey(e => e.IdFormaPago)
                    .HasName("PRIMARY");

                entity.ToTable("t_formas_pago");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.IdFormaPago).HasColumnName("Id_Forma_Pago");

                entity.Property(e => e.FormaPago)
                    .HasMaxLength(45)
                    .HasColumnName("Forma_Pago");
            });

            modelBuilder.Entity<TGrupo>(entity =>
            {
                entity.HasKey(e => e.IdGrupo)
                    .HasName("PRIMARY");

                entity.ToTable("t_grupos");

                entity.HasComment("Grupos de los productos")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.IdGrupo).HasColumnName("Id_Grupo");

                entity.Property(e => e.NomGrupo)
                    .HasMaxLength(50)
                    .HasColumnName("Nom_Grupo");
            });

            modelBuilder.Entity<TInventario>(entity =>
            {
                entity.ToTable("t_inventario");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.CantEnt).HasColumnName("Cant_Ent");

                entity.Property(e => e.CantSal).HasColumnName("Cant_Sal");

                entity.Property(e => e.IdProd).HasColumnName("Id_Prod");

                entity.Property(e => e.SaldoFin).HasColumnName("Saldo_Fin");

                entity.Property(e => e.SaldoIni).HasColumnName("Saldo_Ini");
            });

            modelBuilder.Entity<TInventarioMov>(entity =>
            {
                entity.ToTable("t_inventario_mov");

                entity.HasComment("Movimientos")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Detalle).HasMaxLength(200);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.IdProd).HasColumnName("Id_Prod");

                entity.Property(e => e.TipoMov).HasColumnName("Tipo_Mov");
            });

            modelBuilder.Entity<TMesa>(entity =>
            {
                entity.HasKey(e => e.IdMesa)
                    .HasName("PRIMARY");

                entity.ToTable("t_mesas");

                entity.HasComment("Mesas para cargar cuentas")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.IdMesa).HasColumnName("Id_Mesa");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'D'");

                entity.Property(e => e.NomMesa)
                    .HasMaxLength(15)
                    .HasColumnName("Nom_Mesa");
            });

            modelBuilder.Entity<TMesero>(entity =>
            {
                entity.HasKey(e => e.IdMese)
                    .HasName("PRIMARY");

                entity.ToTable("t_meseros");

                entity.HasComment("Meseros del Restaurante")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.IdMese).HasColumnName("Id_Mese");

                entity.Property(e => e.Activo)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'S'");

                entity.Property(e => e.Anular)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.ApeMese)
                    .HasMaxLength(20)
                    .HasColumnName("Ape_Mese");

                entity.Property(e => e.Cobrar)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Elimina)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'S'");

                entity.Property(e => e.NomMese)
                    .HasMaxLength(10)
                    .HasColumnName("Nom_Mese");
            });

            modelBuilder.Entity<TOpcionesBebida>(entity =>
            {
                entity.HasKey(e => e.IdOpBeb)
                    .HasName("PRIMARY");

                entity.ToTable("t_opciones_bebidas");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.IdOpBeb).HasColumnName("Id_Op_Beb");

                entity.Property(e => e.IdProd).HasColumnName("Id_Prod");

                entity.Property(e => e.NomOpBeb)
                    .HasMaxLength(45)
                    .HasColumnName("Nom_Op_Beb");
            });

            modelBuilder.Entity<TOpcionesEndulzar>(entity =>
            {
                entity.HasKey(e => e.IdOpEnd)
                    .HasName("PRIMARY");

                entity.ToTable("t_opciones_endulzar");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.IdOpEnd).HasColumnName("Id_Op_End");

                entity.Property(e => e.NomOpEnd)
                    .HasMaxLength(45)
                    .HasColumnName("Nom_Op_End");
            });

            modelBuilder.Entity<TOpcionesTermino>(entity =>
            {
                entity.HasKey(e => e.IdOpTer)
                    .HasName("PRIMARY");

                entity.ToTable("t_opciones_terminos");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.IdOpTer).HasColumnName("Id_Op_Ter");

                entity.Property(e => e.NomOpTer)
                    .HasMaxLength(45)
                    .HasColumnName("Nom_Op_Ter");
            });

            modelBuilder.Entity<TOpcionesTono>(entity =>
            {
                entity.HasKey(e => e.IdOpTon)
                    .HasName("PRIMARY");

                entity.ToTable("t_opciones_tonos");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.IdOpTon).HasColumnName("Id_Op_Ton");

                entity.Property(e => e.NomOpTon)
                    .HasMaxLength(50)
                    .HasColumnName("Nom_Op_Ton");
            });

            modelBuilder.Entity<TParametro>(entity =>
            {
                entity.HasKey(e => e.IdPar)
                    .HasName("PRIMARY");

                entity.ToTable("t_parametros");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.IdPar).HasColumnName("Id_Par");

                entity.Property(e => e.ImpreIpc)
                    .HasMaxLength(1)
                    .HasColumnName("Impre_ipc")
                    .HasDefaultValueSql("'S'");

                entity.Property(e => e.NumRbo).HasColumnName("Num_Rbo");
            });

            modelBuilder.Entity<TProducto>(entity =>
            {
                entity.HasKey(e => e.IdProd)
                    .HasName("PRIMARY");

                entity.ToTable("t_productos");

                entity.HasComment("Productos")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.IdProd, "Index_2");

                entity.Property(e => e.IdProd).HasColumnName("Id_Prod");

                entity.Property(e => e.CodProd)
                    .HasMaxLength(50)
                    .HasColumnName("Cod_Prod");

                entity.Property(e => e.Combo)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DefineBebida)
                    .HasMaxLength(1)
                    .HasColumnName("Define_Bebida")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DefineSabor)
                    .HasMaxLength(1)
                    .HasColumnName("Define_Sabor")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DefineTermino)
                    .HasMaxLength(1)
                    .HasColumnName("Define_Termino")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DefineTono)
                    .HasMaxLength(1)
                    .HasColumnName("Define_Tono")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdBod).HasColumnName("Id_Bod");

                entity.Property(e => e.IdGrupo).HasColumnName("Id_Grupo");

                entity.Property(e => e.MonitorBarra)
                    .HasMaxLength(1)
                    .HasColumnName("Monitor_Barra")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.NomProd)
                    .HasMaxLength(150)
                    .HasColumnName("Nom_Prod");

                entity.Property(e => e.PrecioVenta)
                    .HasColumnName("Precio_Venta")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PrecioVenta2)
                    .HasColumnName("precio_venta2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PrecioVenta3)
                    .HasColumnName("precio_venta3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PreparaCocina)
                    .HasMaxLength(1)
                    .HasColumnName("Prepara_Cocina")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.ValorUnitario)
                    .HasColumnName("Valor_Unitario")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TProductosBebida>(entity =>
            {
                entity.HasKey(e => e.IdPb)
                    .HasName("PRIMARY");

                entity.ToTable("t_productos_bebidas");

                entity.HasComment("Fusionar las bebidas")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.IdPb).HasColumnName("Id_PB");

                entity.Property(e => e.IdOpBeb).HasColumnName("Id_Op_Beb");

                entity.Property(e => e.IdProd).HasColumnName("Id_Prod");
            });

            modelBuilder.Entity<TPwd>(entity =>
            {
                entity.ToTable("t_pwd");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.PwAdmin)
                    .HasMaxLength(10)
                    .HasColumnName("pw_admin");

                entity.Property(e => e.PwAnular)
                    .HasMaxLength(10)
                    .HasColumnName("pw_anular");

                entity.Property(e => e.PwComanda)
                    .HasMaxLength(10)
                    .HasColumnName("pw_comanda");
            });

            modelBuilder.Entity<TRecibo>(entity =>
            {
                entity.HasKey(e => e.IdRbo)
                    .HasName("PRIMARY");

                entity.ToTable("t_recibos");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.IdRbo).HasColumnName("Id_Rbo");

                entity.Property(e => e.FechaRbo)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Rbo");

                entity.Property(e => e.IdCli).HasColumnName("Id_Cli");

                entity.Property(e => e.NomCli)
                    .HasMaxLength(255)
                    .HasColumnName("Nom_Cli");

                entity.Property(e => e.NumRbo).HasColumnName("Num_Rbo");

                entity.Property(e => e.VrTotal)
                    .HasColumnName("Vr_Total")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TReporte>(entity =>
            {
                entity.HasKey(e => e.IdtReporte)
                    .HasName("PRIMARY");

                entity.ToTable("t_reporte");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.IdtReporte).HasColumnName("idt_reporte");

                entity.Property(e => e.Forma)
                    .HasMaxLength(100)
                    .HasColumnName("forma");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TResolucion>(entity =>
            {
                entity.HasKey(e => e.IdResol)
                    .HasName("PRIMARY");

                entity.ToTable("t_resolucion");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.IdResol).HasColumnName("Id_Resol");

                entity.Property(e => e.Activa).HasMaxLength(1);

                entity.Property(e => e.CiudEmpre)
                    .HasMaxLength(30)
                    .HasColumnName("ciud_empre");

                entity.Property(e => e.ComentA)
                    .HasMaxLength(100)
                    .HasColumnName("comentA");

                entity.Property(e => e.ComentB)
                    .HasMaxLength(100)
                    .HasColumnName("comentB");

                entity.Property(e => e.DescripResol)
                    .HasMaxLength(60)
                    .HasColumnName("Descrip_Resol");

                entity.Property(e => e.DirEmpre)
                    .HasMaxLength(255)
                    .HasColumnName("dir_empre");

                entity.Property(e => e.FechaResol)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Resol");

                entity.Property(e => e.Nit)
                    .HasMaxLength(60)
                    .HasColumnName("NIT");

                entity.Property(e => e.NomEmpre)
                    .HasMaxLength(100)
                    .HasColumnName("nom_empre");

                entity.Property(e => e.NomRepre)
                    .HasMaxLength(60)
                    .HasColumnName("nom_repre");

                entity.Property(e => e.NumActFact)
                    .HasMaxLength(45)
                    .HasColumnName("Num_Act_Fact");

                entity.Property(e => e.NumFinFact)
                    .HasMaxLength(45)
                    .HasColumnName("Num_Fin_Fact");

                entity.Property(e => e.NumIniFact)
                    .HasMaxLength(45)
                    .HasColumnName("Num_Ini_Fact");

                entity.Property(e => e.PrefijoFact)
                    .HasMaxLength(5)
                    .HasColumnName("Prefijo_Fact");

                entity.Property(e => e.RegimenEmpre)
                    .HasMaxLength(100)
                    .HasColumnName("regimen_empre");

                entity.Property(e => e.TelEmpre)
                    .HasMaxLength(30)
                    .HasColumnName("tel_empre");
            });

            modelBuilder.Entity<TTiposPago>(entity =>
            {
                entity.HasKey(e => e.IdTipoPago)
                    .HasName("PRIMARY");

                entity.ToTable("t_tipos_pago");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.IdTipoPago).HasColumnName("Id_Tipo_Pago");

                entity.Property(e => e.TipoPago)
                    .HasMaxLength(45)
                    .HasColumnName("Tipo_Pago");
            });

            modelBuilder.Entity<TUsuario>(entity =>
            {
                entity.HasKey(e => e.IdUsu)
                    .HasName("PRIMARY");

                entity.ToTable("t_usuarios");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.IdUsu).HasColumnName("id_usu");

                entity.Property(e => e.Activo)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'S'");

                entity.Property(e => e.ClaveUsu)
                    .HasMaxLength(10)
                    .HasColumnName("clave_usu");

                entity.Property(e => e.Contacto).HasMaxLength(300);

                entity.Property(e => e.Email).HasMaxLength(300);

                entity.Property(e => e.MenuContab).HasDefaultValueSql("'0'");

                entity.Property(e => e.MenuMesas).HasDefaultValueSql("'0'");

                entity.Property(e => e.MenuRepo).HasDefaultValueSql("'0'");

                entity.Property(e => e.MenuSiste).HasDefaultValueSql("'0'");

                entity.Property(e => e.Menuprodu).HasDefaultValueSql("'0'");

                entity.Property(e => e.NomUsu)
                    .HasMaxLength(60)
                    .HasColumnName("nom_usu");

                entity.Property(e => e.Nombres).HasMaxLength(150);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
