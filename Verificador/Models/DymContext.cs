using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Verificador.Models
{
    public partial class DymContext : DbContext
    {
        public DymContext()
        {
        }

        public DymContext(DbContextOptions<DymContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actualizacion> Actualizacion { get; set; }
        public virtual DbSet<Almacen> Almacen { get; set; }
        public virtual DbSet<AuditUpdate> AuditUpdate { get; set; }
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<CAduana> CAduana { get; set; }
        public virtual DbSet<CCaducidadfolios> CCaducidadfolios { get; set; }
        public virtual DbSet<CClaveProdServ> CClaveProdServ { get; set; }
        public virtual DbSet<CClaveunidad> CClaveunidad { get; set; }
        public virtual DbSet<CFormapago> CFormapago { get; set; }
        public virtual DbSet<CImpuesto> CImpuesto { get; set; }
        public virtual DbSet<CMetodopago> CMetodopago { get; set; }
        public virtual DbSet<CMoneda> CMoneda { get; set; }
        public virtual DbSet<CNumpedimentoaduana> CNumpedimentoaduana { get; set; }
        public virtual DbSet<CPatenteaduanal> CPatenteaduanal { get; set; }
        public virtual DbSet<CRegimenfiscal> CRegimenfiscal { get; set; }
        public virtual DbSet<CTasaocuota> CTasaocuota { get; set; }
        public virtual DbSet<CTipodecomprobante> CTipodecomprobante { get; set; }
        public virtual DbSet<CTipofactor> CTipofactor { get; set; }
        public virtual DbSet<CUsocfdi> CUsocfdi { get; set; }
        public virtual DbSet<CambiosPrecio> CambiosPrecio { get; set; }
        public virtual DbSet<CardDeletionHistories> CardDeletionHistories { get; set; }
        public virtual DbSet<CardRoles> CardRoles { get; set; }
        public virtual DbSet<CardTransactions> CardTransactions { get; set; }
        public virtual DbSet<Cards> Cards { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<CentroCosto> CentroCosto { get; set; }
        public virtual DbSet<Cexportacion> Cexportacion { get; set; }
        public virtual DbSet<CierreInventario> CierreInventario { get; set; }
        public virtual DbSet<CierreInventariop> CierreInventariop { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Cmeses> Cmeses { get; set; }
        public virtual DbSet<CobjetoImp> CobjetoImp { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<Comprap> Comprap { get; set; }
        public virtual DbSet<ConceptoEgreso> ConceptoEgreso { get; set; }
        public virtual DbSet<ConceptoIngreso> ConceptoIngreso { get; set; }
        public virtual DbSet<ConceptoMovInv> ConceptoMovInv { get; set; }
        public virtual DbSet<Configuracion> Configuracion { get; set; }
        public virtual DbSet<Consecutivo> Consecutivo { get; set; }
        public virtual DbSet<Corte> Corte { get; set; }
        public virtual DbSet<Cp> Cp { get; set; }
        public virtual DbSet<Cperiodicidad> Cperiodicidad { get; set; }
        public virtual DbSet<Ctiporelacion> Ctiporelacion { get; set; }
        public virtual DbSet<Cxc> Cxc { get; set; }
        public virtual DbSet<Cxcdr> Cxcdr { get; set; }
        public virtual DbSet<Cxcp> Cxcp { get; set; }
        public virtual DbSet<Cxp> Cxp { get; set; }
        public virtual DbSet<Cxpp> Cxpp { get; set; }
        public virtual DbSet<Devolucion> Devolucion { get; set; }
        public virtual DbSet<Devolucionp> Devolucionp { get; set; }
        public virtual DbSet<DymError> DymError { get; set; }
        public virtual DbSet<EmailRecords> EmailRecords { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Estacion> Estacion { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<EstadoDoc> EstadoDoc { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Flujo> Flujo { get; set; }
        public virtual DbSet<Impuesto> Impuesto { get; set; }
        public virtual DbSet<Informe> Informe { get; set; }
        public virtual DbSet<InformeCategoria> InformeCategoria { get; set; }
        public virtual DbSet<InformeConfiguracion> InformeConfiguracion { get; set; }
        public virtual DbSet<InformeParametro> InformeParametro { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<Inventariop> Inventariop { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<Jobp> Jobp { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<Kardex> Kardex { get; set; }
        public virtual DbSet<Laboratorio> Laboratorio { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Lote> Lote { get; set; }
        public virtual DbSet<LoteVentap> LoteVentap { get; set; }
        public virtual DbSet<Lxc> Lxc { get; set; }
        public virtual DbSet<LxcDocument> LxcDocument { get; set; }
        public virtual DbSet<MergeTemplates> MergeTemplates { get; set; }
        public virtual DbSet<MessageUsers> MessageUsers { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<MigrationField> MigrationField { get; set; }
        public virtual DbSet<MigrationTable> MigrationTable { get; set; }
        public virtual DbSet<Moneda> Moneda { get; set; }
        public virtual DbSet<MotivoCancelacion> MotivoCancelacion { get; set; }
        public virtual DbSet<MovInv> MovInv { get; set; }
        public virtual DbSet<Municipio> Municipio { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Permiso> Permiso { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Presentacion> Presentacion { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<ProductoAlmacen> ProductoAlmacen { get; set; }
        public virtual DbSet<ProductoProveedor> ProductoProveedor { get; set; }
        public virtual DbSet<ProductoSustancia> ProductoSustancia { get; set; }
        public virtual DbSet<ProductoUbicacion> ProductoUbicacion { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Punto> Punto { get; set; }
        public virtual DbSet<PuntoConfig> PuntoConfig { get; set; }
        public virtual DbSet<Query> Query { get; set; }
        public virtual DbSet<Reporte> Reporte { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RolePermiso> RolePermiso { get; set; }
        public virtual DbSet<SatExecutionType> SatExecutionType { get; set; }
        public virtual DbSet<SatFile> SatFile { get; set; }
        public virtual DbSet<SatOrder> SatOrder { get; set; }
        public virtual DbSet<SatPackage> SatPackage { get; set; }
        public virtual DbSet<SatRequest> SatRequest { get; set; }
        public virtual DbSet<SatResponse> SatResponse { get; set; }
        public virtual DbSet<SatXml> SatXml { get; set; }
        public virtual DbSet<SatXmlItem> SatXmlItem { get; set; }
        public virtual DbSet<Sector> Sector { get; set; }
        public virtual DbSet<Sucursal> Sucursal { get; set; }
        public virtual DbSet<Sustancia> Sustancia { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<TipoDoc> TipoDoc { get; set; }
        public virtual DbSet<TipoInventario> TipoInventario { get; set; }
        public virtual DbSet<Traspaso> Traspaso { get; set; }
        public virtual DbSet<Traspasop> Traspasop { get; set; }
        public virtual DbSet<Ubicacion> Ubicacion { get; set; }
        public virtual DbSet<UnidadMedida> UnidadMedida { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioRole> UsuarioRole { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }
        public virtual DbSet<VentaImpuesto> VentaImpuesto { get; set; }
        public virtual DbSet<Ventap> Ventap { get; set; }
        public virtual DbSet<VentapImpuesto> VentapImpuesto { get; set; }
        public virtual DbSet<Vlu> Vlu { get; set; }

        // Unable to generate entity type for table 'dbo.ChangeLog'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var cn = DataHelper.GetConnectionString();
                //var cn = @"Server=.\SQLExpress;Database=Dym;Trusted_Connection=True;";
                optionsBuilder.UseSqlServer(cn);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Actualizacion>(entity =>
            {
                entity.Property(e => e.AppliedDate).HasColumnType("datetime");

                entity.Property(e => e.Appliedby)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.ScriptSql).IsRequired();

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Almacen>(entity =>
            {
                entity.HasIndex(e => e.CentroCostoId);

                entity.HasIndex(e => e.CompradorStandardId);

                entity.HasIndex(e => e.Nombre);

                entity.Property(e => e.AlmacenId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CentroCostoId).HasMaxLength(50);

                entity.Property(e => e.CompradorStandardId).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Observacion).HasMaxLength(300);

                entity.Property(e => e.PermiteGenerarPrestamos)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.PermiteRequisitarMaterialNoLiberado)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.CentroCosto)
                    .WithMany(p => p.Almacen)
                    .HasForeignKey(d => d.CentroCostoId);

                entity.HasOne(d => d.CompradorStandard)
                    .WithMany(p => p.Almacen)
                    .HasForeignKey(d => d.CompradorStandardId);
            });

            modelBuilder.Entity<AuditUpdate>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Banco>(entity =>
            {
                entity.HasIndex(e => e.NombreComercial);

                entity.HasIndex(e => e.RazonSocial);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.NombreComercial).HasMaxLength(500);

                entity.Property(e => e.RazonSocial).HasMaxLength(500);

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<CAduana>(entity =>
            {
                entity.ToTable("C_Aduana");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CAduana1)
                    .HasColumnName("c_Aduana")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripción).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<CCaducidadfolios>(entity =>
            {
                entity.ToTable("C_Caducidadfolios");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.DiasCaducidad).HasColumnName("diasCaducidad");

                entity.Property(e => e.PorcentajeCaducidad).HasColumnName("porcentajeCaducidad");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<CClaveProdServ>(entity =>
            {
                entity.HasKey(e => e.ClaveProdServId)
                    .HasName("PK_ClaveSat");

                entity.ToTable("C_ClaveProdServ");

                entity.Property(e => e.ClaveProdServId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<CClaveunidad>(entity =>
            {
                entity.HasKey(e => e.ClaveUnidadId);

                entity.ToTable("C_Claveunidad");

                entity.HasIndex(e => e.Descripcion);

                entity.HasIndex(e => e.Nombre);

                entity.Property(e => e.ClaveUnidadId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<CFormapago>(entity =>
            {
                entity.HasKey(e => e.FormaPagoId)
                    .HasName("PK_C_Formapago_1");

                entity.ToTable("C_Formapago");

                entity.Property(e => e.FormaPagoId)
                    .HasMaxLength(5)
                    .ValueGeneratedNever();

                entity.Property(e => e.Bancarizado).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<CImpuesto>(entity =>
            {
                entity.HasKey(e => e.ImpuestoId);

                entity.ToTable("C_Impuesto");

                entity.Property(e => e.ImpuestoId)
                    .HasMaxLength(5)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Retencion).HasMaxLength(255);

                entity.Property(e => e.Traslado).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<CMetodopago>(entity =>
            {
                entity.HasKey(e => e.MetodoPagoId)
                    .HasName("PK_C_Metodopago_1");

                entity.ToTable("C_Metodopago");

                entity.Property(e => e.MetodoPagoId)
                    .HasMaxLength(5)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<CMoneda>(entity =>
            {
                entity.HasKey(e => e.MonedaId);

                entity.ToTable("C_Moneda");

                entity.Property(e => e.MonedaId)
                    .HasMaxLength(5)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<CNumpedimentoaduana>(entity =>
            {
                entity.HasKey(e => e.CAduana);

                entity.ToTable("C_Numpedimentoaduana");

                entity.Property(e => e.CAduana)
                    .HasColumnName("c_Aduana")
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.Cantidad).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Ejercicio).HasMaxLength(255);

                entity.Property(e => e.FechaFinDeVigencia)
                    .HasColumnName("Fecha fin de vigencia")
                    .HasMaxLength(255);

                entity.Property(e => e.FechaInicioDeVigencia)
                    .HasColumnName("Fecha inicio de vigencia")
                    .HasMaxLength(255);

                entity.Property(e => e.Patente).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<CPatenteaduanal>(entity =>
            {
                entity.ToTable("C_Patenteaduanal");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CPatenteAduanal1)
                    .HasColumnName("C_PatenteAduanal")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.FinDeVigencia)
                    .HasColumnName("Fin de vigencia")
                    .HasMaxLength(255);

                entity.Property(e => e.InicioDeVigencia)
                    .HasColumnName("Inicio de vigencia")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<CRegimenfiscal>(entity =>
            {
                entity.HasKey(e => e.RegimenFiscalId)
                    .HasName("PK_C_Regimenfiscal_1");

                entity.ToTable("C_Regimenfiscal");

                entity.Property(e => e.RegimenFiscalId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Física).HasMaxLength(255);

                entity.Property(e => e.Moral).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<CTasaocuota>(entity =>
            {
                entity.ToTable("C_Tasaocuota");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Factor).HasMaxLength(255);

                entity.Property(e => e.FechaFinDeVigencia)
                    .HasColumnName("Fecha fin de vigencia")
                    .HasMaxLength(255);

                entity.Property(e => e.FechaInicioDeVigencia)
                    .HasColumnName("Fecha inicio de vigencia")
                    .HasMaxLength(255);

                entity.Property(e => e.Impuesto).HasMaxLength(255);

                entity.Property(e => e.RangoOfijo)
                    .HasColumnName("RangoOFijo")
                    .HasMaxLength(255);

                entity.Property(e => e.Retención).HasMaxLength(255);

                entity.Property(e => e.Traslado).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.ValorMáximo)
                    .HasColumnName("Valor máximo")
                    .HasMaxLength(255);

                entity.Property(e => e.ValorMínimo)
                    .HasColumnName("Valor mínimo")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CTipodecomprobante>(entity =>
            {
                entity.HasKey(e => e.TipoComprobanteId)
                    .HasName("PK_C_Tipodecomprobante_1");

                entity.ToTable("C_Tipodecomprobante");

                entity.Property(e => e.TipoComprobanteId)
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<CTipofactor>(entity =>
            {
                entity.HasKey(e => e.TipoFactorId)
                    .HasName("PK_C_Tipofactor_1");

                entity.ToTable("C_Tipofactor");

                entity.Property(e => e.TipoFactorId)
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<CUsocfdi>(entity =>
            {
                entity.HasKey(e => e.UsoCfdiid)
                    .HasName("PK_C_Usocfdi_1");

                entity.ToTable("C_Usocfdi");

                entity.Property(e => e.UsoCfdiid)
                    .HasColumnName("UsoCFDIId")
                    .HasMaxLength(5)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Fisica).HasMaxLength(255);

                entity.Property(e => e.Moral).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<CambiosPrecio>(entity =>
            {
                entity.HasKey(e => e.CambioPrecioId);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Estado).HasMaxLength(50);

                entity.Property(e => e.GridEntradaXcompra)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Observacion).HasMaxLength(200);

                entity.Property(e => e.Precio1Nuevo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Precio1Viejo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Precio2Nuevo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Precio2Viejo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Precio3Nuevo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Precio3Viejo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Precio4Nuevo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Precio4Viejo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PrecioCajaNuevo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PrecioCajaViejo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PrecioCompraNuevo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PrecioCompraViejo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ProductoId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.Utilidad1Nuevo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Utilidad1Viejo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Utilidad2Nuevo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Utilidad2Viejo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Utilidad3Nuevo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Utilidad3Viejo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Utilidad4Nuevo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Utilidad4Viejo).HasColumnType("decimal(18, 3)");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CambiosPrecio)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CambiosPrecio_Usuario");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.CambiosPrecio)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CambiosPrecio_Producto");
            });

            modelBuilder.Entity<CardDeletionHistories>(entity =>
            {
                entity.HasKey(e => e.CardDeletionHistoryId);

                entity.HasIndex(e => e.CardId);

                entity.Property(e => e.Ammount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CardId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.WasActiveAtTime)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.CardDeletionHistories)
                    .HasForeignKey(d => d.CardId);
            });

            modelBuilder.Entity<CardRoles>(entity =>
            {
                entity.HasKey(e => e.CardRoleId);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<CardTransactions>(entity =>
            {
                entity.HasKey(e => e.CardTransactionId);

                entity.HasIndex(e => e.CardId);

                entity.HasIndex(e => e.CardRoleId);

                entity.HasIndex(e => e.ClienteId);

                entity.HasIndex(e => e.VentaId);

                entity.Property(e => e.Ammount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BonusRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CardId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ClienteId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.CardTransactions)
                    .HasForeignKey(d => d.CardId);

                entity.HasOne(d => d.CardRole)
                    .WithMany(p => p.CardTransactions)
                    .HasForeignKey(d => d.CardRoleId);

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.CardTransactions)
                    .HasForeignKey(d => d.ClienteId);

                entity.HasOne(d => d.Venta)
                    .WithMany(p => p.CardTransactions)
                    .HasForeignKey(d => d.VentaId);
            });

            modelBuilder.Entity<Cards>(entity =>
            {
                entity.HasKey(e => e.CardId);

                entity.Property(e => e.CardId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.BonusRate).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasIndex(e => e.Nombre);

                entity.Property(e => e.CategoriaId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<CentroCosto>(entity =>
            {
                entity.Property(e => e.CentroCostoId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Cexportacion>(entity =>
            {
                entity.ToTable("CExportacion");

                entity.Property(e => e.CexportacionId)
                    .HasColumnName("CExportacionId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<CierreInventario>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.EstacionId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaFinal).HasColumnType("date");

                entity.Property(e => e.FechaInicial).HasColumnType("date");

                entity.Property(e => e.FechaProgramacion).HasColumnType("date");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CierreInventario)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CierreInventarioId_Usuario");

                entity.HasOne(d => d.Estacion)
                    .WithMany(p => p.CierreInventario)
                    .HasForeignKey(d => d.EstacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CierreInventarioId_Estacion");
            });

            modelBuilder.Entity<CierreInventariop>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(550);

                entity.Property(e => e.Entradas).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InvFinal).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InvInicial).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PrevioVta).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ProductoId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Salidas).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Stock).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UltimoCosto).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.ValorCosto).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ValorVenta).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.CierreInventario)
                    .WithMany(p => p.CierreInventariop)
                    .HasForeignKey(d => d.CierreInventarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CierreInventariop_CierreInventarioId");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.CierreInventariop)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CierreInventariop_Producto");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasIndex(e => e.BancoChid);

                entity.HasIndex(e => e.BancoTdcid);

                entity.HasIndex(e => e.BancoTddid);

                entity.HasIndex(e => e.BancoTefid);

                entity.HasIndex(e => e.CardId);

                entity.HasIndex(e => e.CardRoleId);

                entity.HasIndex(e => e.Negocio);

                entity.HasIndex(e => e.RazonSocial);

                entity.Property(e => e.ClienteId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.BancoChid).HasColumnName("BancoCHId");

                entity.Property(e => e.BancoTdcid).HasColumnName("BancoTDCId");

                entity.Property(e => e.BancoTddid).HasColumnName("BancoTDDId");

                entity.Property(e => e.BancoTefid).HasColumnName("BancoTEFId");

                entity.Property(e => e.CardId).HasMaxLength(50);

                entity.Property(e => e.CardRoleDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'DESCONSIDERA.')");

                entity.Property(e => e.CardRoleId).HasDefaultValueSql("((1))");

                entity.Property(e => e.Celular).HasMaxLength(50);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CuentaOrdCh)
                    .HasColumnName("CuentaOrdCH")
                    .HasMaxLength(50);

                entity.Property(e => e.CuentaOrdTdc)
                    .HasColumnName("CuentaOrdTDC")
                    .HasMaxLength(50);

                entity.Property(e => e.CuentaOrdTdd)
                    .HasColumnName("CuentaOrdTDD")
                    .HasMaxLength(50);

                entity.Property(e => e.CuentaOrdTef)
                    .HasColumnName("CuentaOrdTEF")
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.DineroElectronico).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EsCxc).HasDefaultValueSql("((0))");

                entity.Property(e => e.Estado).HasMaxLength(50);

                entity.Property(e => e.FormaPagoId)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.LimiteCredito).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Localidad).HasMaxLength(50);

                entity.Property(e => e.MetodoPagoId)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Municipio).HasMaxLength(50);

                entity.Property(e => e.Negocio).HasMaxLength(300);

                entity.Property(e => e.NoTarjetaPuntos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.PrecioDefault).HasDefaultValueSql("((1))");

                entity.Property(e => e.RazonSocial).HasMaxLength(300);

                entity.Property(e => e.RegimenFiscal).HasMaxLength(255);

                entity.Property(e => e.RegimenFiscalId).HasMaxLength(25);

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasMaxLength(50);

                entity.Property(e => e.Saldo).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Telefono).HasMaxLength(50);

                entity.Property(e => e.UsoCfdiid)
                    .IsRequired()
                    .HasColumnName("UsoCFDIId")
                    .HasMaxLength(5);

                entity.HasOne(d => d.BancoCh)
                    .WithMany(p => p.ClienteBancoCh)
                    .HasForeignKey(d => d.BancoChid);

                entity.HasOne(d => d.BancoTdc)
                    .WithMany(p => p.ClienteBancoTdc)
                    .HasForeignKey(d => d.BancoTdcid);

                entity.HasOne(d => d.BancoTdd)
                    .WithMany(p => p.ClienteBancoTdd)
                    .HasForeignKey(d => d.BancoTddid);

                entity.HasOne(d => d.BancoTef)
                    .WithMany(p => p.ClienteBancoTef)
                    .HasForeignKey(d => d.BancoTefid);

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.CardId);

                entity.HasOne(d => d.CardRole)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.CardRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.FormaPago)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.FormaPagoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cliente_C_Formapago1");

                entity.HasOne(d => d.MetodoPago)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.MetodoPagoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cliente_C_Metodopago");

                entity.HasOne(d => d.UsoCfdi)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.UsoCfdiid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cliente_C_Usocfdi");
            });

            modelBuilder.Entity<Cmeses>(entity =>
            {
                entity.ToTable("CMeses");

                entity.Property(e => e.CmesesId)
                    .HasColumnName("CMesesId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<CobjetoImp>(entity =>
            {
                entity.ToTable("CObjetoImp");

                entity.Property(e => e.CobjetoImpId)
                    .HasColumnName("CObjetoImpId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion).HasMaxLength(255);
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.Property(e => e.AlmacenId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'SYS')");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'SYS')");

                entity.Property(e => e.Datos).IsRequired();

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.EsCxp).HasColumnName("EsCXP");

                entity.Property(e => e.EstacionId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'SYS')");

                entity.Property(e => e.EstadoDocId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'PEN')");

                entity.Property(e => e.FacturaProveedor)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaDocumento)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Impuesto).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ProveedorId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProveedorName)
                    .IsRequired()
                    .HasMaxLength(350);

                entity.Property(e => e.TipoDocId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'COM')");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Compra_Usuario");

                entity.HasOne(d => d.Cxp)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.CxpId)
                    .HasConstraintName("FK_Compra_CXP");

                entity.HasOne(d => d.Estacion)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.EstacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Compra_Estacion");

                entity.HasOne(d => d.EstadoDoc)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.EstadoDocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Compra_EstadoDoc");

                entity.HasOne(d => d.TipoDoc)
                    .WithMany(p => p.Compra)
                    .HasForeignKey(d => d.TipoDocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Compra_TipoDoc");
            });

            modelBuilder.Entity<Comprap>(entity =>
            {
                entity.Property(e => e.Caducidad)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).IsRequired();

                entity.Property(e => e.Descuento).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteImpuesto1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteImpuesto2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Impuesto1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Impuesto2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LaboratorioId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'SYS')");

                entity.Property(e => e.LaboratorioName)
                    .IsRequired()
                    .HasMaxLength(350);

                entity.Property(e => e.Lote)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'SYS')");

                entity.Property(e => e.NImpuestos).HasColumnName("nImpuestos");

                entity.Property(e => e.Precio1).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Precio2).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PrecioCaja).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecioCompra).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecioSalida1).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PrecioSalida2).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ProductoId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Stock).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.Utilidad1).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Utilidad2).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.Compra)
                    .WithMany(p => p.Comprap)
                    .HasForeignKey(d => d.CompraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comprap_Compra");
            });

            modelBuilder.Entity<ConceptoEgreso>(entity =>
            {
                entity.Property(e => e.ConceptoEgresoId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<ConceptoIngreso>(entity =>
            {
                entity.Property(e => e.ConceptoIngresoId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<ConceptoMovInv>(entity =>
            {
                entity.Property(e => e.ConceptoMovInvId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Es)
                    .IsRequired()
                    .HasColumnName("ES")
                    .HasMaxLength(1);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Configuracion>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.RutaCadenaOriginal).HasMaxLength(250);

                entity.Property(e => e.RutaCer).HasMaxLength(250);

                entity.Property(e => e.RutaComprobantes).HasMaxLength(250);

                entity.Property(e => e.RutaCortes).HasMaxLength(250);

                entity.Property(e => e.RutaFormatoCorte).HasMaxLength(250);

                entity.Property(e => e.RutaFormatoFactura).HasMaxLength(250);

                entity.Property(e => e.RutaFormatoTicket).HasMaxLength(250);

                entity.Property(e => e.RutaKey).HasMaxLength(250);

                entity.Property(e => e.RutaPlantillas).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Consecutivo>(entity =>
            {
                entity.Property(e => e.ConsecutivoId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Corte>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.EstacionId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaFinal).HasColumnType("datetime");

                entity.Property(e => e.FechaInicial).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RutaArchivo)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Corte)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Corte_Usuario");

                entity.HasOne(d => d.Estacion)
                    .WithMany(p => p.Corte)
                    .HasForeignKey(d => d.EstacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Corte_Estacion");
            });

            modelBuilder.Entity<Cp>(entity =>
            {
                entity.ToTable("CP");

                entity.HasIndex(e => e.Codigo);

                entity.Property(e => e.CpId).ValueGeneratedNever();

                entity.Property(e => e.Codigo).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Municipio)
                    .WithMany(p => p.Cp)
                    .HasForeignKey(d => d.MunicipioId)
                    .HasConstraintName("FK_CP_Municipio");
            });

            modelBuilder.Entity<Cperiodicidad>(entity =>
            {
                entity.ToTable("CPeriodicidad");

                entity.Property(e => e.CperiodicidadId)
                    .HasColumnName("CPeriodicidadId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Ctiporelacion>(entity =>
            {
                entity.ToTable("CTiporelacion");

                entity.Property(e => e.CtiporelacionId)
                    .HasColumnName("CTiporelacionId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Cxc>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.Property(e => e.ClienteId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.EstacionId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EstadoDocId)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasDefaultValueSql("(N'PEN')");

                entity.Property(e => e.FechaDocumento).HasColumnType("datetime");

                entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");

                entity.Property(e => e.Impuesto).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MonedaId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasDefaultValueSql("(N'MXN')");

                entity.Property(e => e.Observacion).HasMaxLength(500);

                entity.Property(e => e.Recalculada)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Saldo).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SerieDocId)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TipoDocId)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Cxc)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cxc_Usuario");
            });

            modelBuilder.Entity<Cxcdr>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.CxcpId);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.EstacionId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Folio)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdDocumento)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ImportePagado).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ImporteSaldoAnt).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ImporteSaldoInsoluto).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MetodoPagoDr)
                    .IsRequired()
                    .HasColumnName("MetodoPagoDR")
                    .HasMaxLength(50);

                entity.Property(e => e.MonedaDr)
                    .IsRequired()
                    .HasColumnName("MonedaDR")
                    .HasMaxLength(50);

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoCambioDr)
                    .HasColumnName("TipoCambioDR")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Cxcdr)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cxcdr_Usuario");

                entity.HasOne(d => d.Cxcp)
                    .WithMany(p => p.Cxcdr)
                    .HasForeignKey(d => d.CxcpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cxcdr_Cxcp");
            });

            modelBuilder.Entity<Cxcp>(entity =>
            {
                entity.HasIndex(e => e.CxcId);

                entity.HasIndex(e => e.MotivoCancelacionId);

                entity.Property(e => e.AmbienteWs).HasMaxLength(50);

                entity.Property(e => e.ClienteId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CtaBeneficiario).HasMaxLength(50);

                entity.Property(e => e.CtaOrdenante).HasMaxLength(50);

                entity.Property(e => e.DebitoCredito)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.EstacionId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EstatusSat).HasMaxLength(50);

                entity.Property(e => e.FechaPago).HasColumnType("datetime");

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Monto).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MotivoCancelacionId).HasMaxLength(3);

                entity.Property(e => e.Ndocumentos).HasColumnName("NDocumentos");

                entity.Property(e => e.NoCertificado).HasMaxLength(50);

                entity.Property(e => e.NomBancoOrdExtranjero).HasMaxLength(50);

                entity.Property(e => e.NumOperacion).HasMaxLength(50);

                entity.Property(e => e.Observacion).HasMaxLength(500);

                entity.Property(e => e.Proporcion).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ReferenciaBancaria).HasMaxLength(50);

                entity.Property(e => e.RfcCtaBen).HasMaxLength(50);

                entity.Property(e => e.RfcCtaOrd).HasMaxLength(50);

                entity.Property(e => e.RutaXml).HasMaxLength(500);

                entity.Property(e => e.TipoCambiop).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UuId).HasMaxLength(50);

                entity.Property(e => e.UuidSustitucion).HasMaxLength(50);

                entity.HasOne(d => d.Cxc)
                    .WithMany(p => p.Cxcp)
                    .HasForeignKey(d => d.CxcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cxcp_Cxc");

                entity.HasOne(d => d.MotivoCancelacion)
                    .WithMany(p => p.Cxcp)
                    .HasForeignKey(d => d.MotivoCancelacionId);
            });

            modelBuilder.Entity<Cxp>(entity =>
            {
                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.EstadoDocId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'PEN')");

                entity.Property(e => e.FacturaProveedor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'NO ESPECIFICADO')");

                entity.Property(e => e.FechaDocumento)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ProveedorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'SYS')");

                entity.Property(e => e.Saldo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TipoDocId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'COM')");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Cxp)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cxp_Usuario");

                entity.HasOne(d => d.EstadoDoc)
                    .WithMany(p => p.Cxp)
                    .HasForeignKey(d => d.EstadoDocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CXP_EstadoDoc");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.Cxp)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CXP_Proveedor");

                entity.HasOne(d => d.TipoDoc)
                    .WithMany(p => p.Cxp)
                    .HasForeignKey(d => d.TipoDocId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CXP_TipoDoc");
            });

            modelBuilder.Entity<Cxpp>(entity =>
            {
                entity.Property(e => e.CargoAbono)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ProveedorId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Cxp)
                    .WithMany(p => p.Cxpp)
                    .HasForeignKey(d => d.CxpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cxpp_Cxp");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.Cxpp)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCXP_Proveedor");
            });

            modelBuilder.Entity<Devolucion>(entity =>
            {
                entity.Property(e => e.ConceptoMovInvId).HasMaxLength(10);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Documento).HasMaxLength(50);

                entity.Property(e => e.EstadoDocId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Impuesto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProveedorId).HasMaxLength(10);

                entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Devolucion)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Devolucion_Usuario");
            });

            modelBuilder.Entity<Devolucionp>(entity =>
            {
                entity.Property(e => e.Caducidad).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).IsRequired();

                entity.Property(e => e.ImporteImpuesto1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteImpuesto2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Impuesto1).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Impuesto2).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ImpuestoId1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ImpuestoId2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NoLote).HasMaxLength(50);

                entity.Property(e => e.PrecioCompra).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ProductoId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Devolucion)
                    .WithMany(p => p.Devolucionp)
                    .HasForeignKey(d => d.DevolucionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Devolucionp_Devolucion");
            });

            modelBuilder.Entity<DymError>(entity =>
            {
                entity.Property(e => e.DymErrorId).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.LoggedUser).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.VentaId).HasMaxLength(50);
            });

            modelBuilder.Entity<EmailRecords>(entity =>
            {
                entity.HasKey(e => e.EmailRecordId);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasIndex(e => e.BancoId);

                entity.Property(e => e.AskToUseEwalletBalanceAutomatically)
                    .IsRequired()
                    .HasColumnName("AskToUseEWalletBalanceAutomatically")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.AsuntoStd).HasMaxLength(250);

                entity.Property(e => e.ClavePrivada).HasMaxLength(50);

                entity.Property(e => e.CorreoEnvios).HasMaxLength(250);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CuentaBeneficiaria).HasMaxLength(50);

                entity.Property(e => e.DaysSatComunications)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((6.0))");

                entity.Property(e => e.DaysToSendNotifications)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((1.0))");

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.DirectorioAbonos).HasMaxLength(250);

                entity.Property(e => e.DirectorioComp).HasMaxLength(250);

                entity.Property(e => e.DirectorioComprobantes).HasMaxLength(250);

                entity.Property(e => e.DirectorioCortes).HasMaxLength(250);

                entity.Property(e => e.DirectorioDevCom).HasMaxLength(250);

                entity.Property(e => e.DirectorioImg).HasMaxLength(250);

                entity.Property(e => e.DirectorioInverarios).HasMaxLength(250);

                entity.Property(e => e.DirectorioOpenSslBin).HasMaxLength(250);

                entity.Property(e => e.DirectorioReportes).HasMaxLength(250);

                entity.Property(e => e.DirectorioTickets).HasMaxLength(250);

                entity.Property(e => e.DirectorioTrabajo).HasMaxLength(250);

                entity.Property(e => e.DirectorioTraspasos).HasMaxLength(250);

                entity.Property(e => e.FormaPagoCxcid)
                    .HasColumnName("FormaPagoCXCId")
                    .HasMaxLength(50);

                entity.Property(e => e.FormatoCatProds).HasMaxLength(250);

                entity.Property(e => e.FormatoCierres).HasMaxLength(250);

                entity.Property(e => e.FormatoClientesXpuntos).HasMaxLength(250);

                entity.Property(e => e.FormatoComprasVsventas).HasMaxLength(250);

                entity.Property(e => e.FormatoComprasXperido).HasMaxLength(250);

                entity.Property(e => e.FormatoCortes).HasMaxLength(250);

                entity.Property(e => e.FormatoEntradaXcompra).HasMaxLength(250);

                entity.Property(e => e.FormatoInventarioAut).HasMaxLength(250);

                entity.Property(e => e.FormatoMovsInv).HasMaxLength(250);

                entity.Property(e => e.FormatoParaFacturas).HasMaxLength(250);

                entity.Property(e => e.FormatoParaTickets).HasMaxLength(250);

                entity.Property(e => e.FormatoProdsXcompra).HasMaxLength(250);

                entity.Property(e => e.FormatoProdsXprecios).HasMaxLength(250);

                entity.Property(e => e.FormatoProveed).HasMaxLength(250);

                entity.Property(e => e.FormatoStockXprods).HasMaxLength(250);

                entity.Property(e => e.FormatoVentasAcosto).HasMaxLength(250);

                entity.Property(e => e.FormatoVentasXperiodo).HasMaxLength(250);

                entity.Property(e => e.FormatoVentasXperiodoDet).HasMaxLength(250);

                entity.Property(e => e.FormatoVentasXpuntos).HasMaxLength(250);

                entity.Property(e => e.InvervalDownloader).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InvervalSatComunications).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.IpServer).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobsMachineName)
                    .IsRequired()
                    .HasMaxLength(70)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LastDeletionDate).HasDefaultValueSql("('2050-01-01T00:00:00.0000000')");

                entity.Property(e => e.LaunchXmlDownloader)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.LiquidarLxcValorSup)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.MensajeStd).HasMaxLength(250);

                entity.Property(e => e.MicroPvdb).HasMaxLength(550);

                entity.Property(e => e.NextDeleteDate).HasDefaultValueSql("('2050-01-01T00:00:00.0000000')");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.PackageDirectory).HasMaxLength(250);

                entity.Property(e => e.PassEnvioCorreos).HasMaxLength(250);

                entity.Property(e => e.PassWstimbrado)
                    .HasColumnName("PassWSTimbrado")
                    .HasMaxLength(50);

                entity.Property(e => e.Puerto).HasMaxLength(250);

                entity.Property(e => e.RateToPoints)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((1.0))");

                entity.Property(e => e.RegimenFiscal).HasMaxLength(50);

                entity.Property(e => e.RegimenFiscalId).HasMaxLength(50);

                entity.Property(e => e.RequireAuthorizationCheck)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Rfc).HasMaxLength(13);

                entity.Property(e => e.RunTemporalTask)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(1)))");

                entity.Property(e => e.RutaArchivoPfx)
                    .HasColumnName("RutaArchivoPFX")
                    .HasMaxLength(50);

                entity.Property(e => e.RutaCadenaOriginal).HasMaxLength(250);

                entity.Property(e => e.RutaCer).HasMaxLength(250);

                entity.Property(e => e.RutaFormatoCorte).HasMaxLength(250);

                entity.Property(e => e.RutaFormatoFactura).HasMaxLength(250);

                entity.Property(e => e.RutaFormatoTicket).HasMaxLength(250);

                entity.Property(e => e.RutaKey).HasMaxLength(250);

                entity.Property(e => e.RutaPlantillaDetalleTraspaso).HasMaxLength(250);

                entity.Property(e => e.SalePaidWithPointsGeneratesPoints)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.SmtpClient).HasMaxLength(250);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UseClassicPurchaseForm)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.UseClassicTransferForm)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(1)))");

                entity.Property(e => e.UsePointsSubsystem)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.UseRoundingForce)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.UserWstimbrado)
                    .HasColumnName("UserWSTimbrado")
                    .HasMaxLength(50);

                entity.Property(e => e.ValidarFormasPagoBancarizadas)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.XmlDownloaderConfigured)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.HasOne(d => d.Banco)
                    .WithMany(p => p.Empresa)
                    .HasForeignKey(d => d.BancoId);

                entity.HasOne(d => d.RegimenFiscalNavigation)
                    .WithMany(p => p.Empresa)
                    .HasForeignKey(d => d.RegimenFiscalId)
                    .HasConstraintName("FK_Empresa_C_Regimenfiscal");
            });

            modelBuilder.Entity<Estacion>(entity =>
            {
                entity.Property(e => e.EstacionId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DefaultAlmacenId).HasDefaultValueSql("((1))");

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.ImpresoraA).HasMaxLength(250);

                entity.Property(e => e.ImpresoraC).HasMaxLength(250);

                entity.Property(e => e.ImpresoraF)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'N/A')");

                entity.Property(e => e.ImpresoraNc)
                    .IsRequired()
                    .HasColumnName("ImpresoraNC")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'N/A')");

                entity.Property(e => e.ImpresoraT)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'N/A')");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'SIN NOMBRE')");

                entity.Property(e => e.SolicitarFmpago).HasColumnName("SolicitarFMPago");

                entity.Property(e => e.SumarUnidadesPdv).HasColumnName("SumarUnidadesPDV");

                entity.Property(e => e.TantosF).HasDefaultValueSql("((1))");

                entity.Property(e => e.TantosNc)
                    .HasColumnName("TantosNC")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TantosT).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.Property(e => e.EstadoId).ValueGeneratedNever();

                entity.Property(e => e.Codigo).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Estado)
                    .HasForeignKey(d => d.PaisId)
                    .HasConstraintName("FK_Estado_Pais");
            });

            modelBuilder.Entity<EstadoDoc>(entity =>
            {
                entity.Property(e => e.EstadoDocId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InsertedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JsonData).IsRequired();

                entity.Property(e => e.LoggedUserId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Flujo>(entity =>
            {
                entity.Property(e => e.ConceptoId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ConceptoPagoId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Es)
                    .IsRequired()
                    .HasColumnName("ES")
                    .HasMaxLength(1);

                entity.Property(e => e.EstacionId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Referenciap)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Concepto)
                    .WithMany(p => p.Flujo)
                    .HasForeignKey(d => d.ConceptoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Flujo_ConceptoIngreso");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Flujo)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Flujo_Usuario");

                entity.HasOne(d => d.Estacion)
                    .WithMany(p => p.Flujo)
                    .HasForeignKey(d => d.EstacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Flujo_Estacion");
            });

            modelBuilder.Entity<Impuesto>(entity =>
            {
                entity.Property(e => e.ImpuestoId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CImpuesto)
                    .IsRequired()
                    .HasColumnName("C_Impuesto")
                    .HasMaxLength(5);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Tasa).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.CImpuestoNavigation)
                    .WithMany(p => p.Impuesto)
                    .HasForeignKey(d => d.CImpuesto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Impuesto_C_Impuesto_ImpuestoId_fk");
            });

            modelBuilder.Entity<Informe>(entity =>
            {
                entity.Property(e => e.InformeId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Codigo).IsRequired();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.InformeCateforia)
                    .WithMany(p => p.Informe)
                    .HasForeignKey(d => d.InformeCateforiaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Informe_InformeCategoria");
            });

            modelBuilder.Entity<InformeCategoria>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<InformeConfiguracion>(entity =>
            {
                entity.Property(e => e.Abono)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Complemento)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.InformeId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Lxc)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Regla)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Informe)
                    .WithMany(p => p.InformeConfiguracion)
                    .HasForeignKey(d => d.InformeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InformeConfiguracion_Informe");
            });

            modelBuilder.Entity<InformeParametro>(entity =>
            {
                entity.HasKey(e => e.ParametroId);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Estandar).HasMaxLength(50);

                entity.Property(e => e.InformeId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Informe)
                    .WithMany(p => p.InformeParametro)
                    .HasForeignKey(d => d.InformeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InformeParametro_Informe");
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EstacionId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EstadoDocId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaAutorizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaBloqueo).HasColumnType("datetime");

                entity.Property(e => e.Ocupado).HasDefaultValueSql("('FALSE')");

                entity.Property(e => e.OcupadoBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TipoInventario)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UsuarioAutorizacion).HasMaxLength(50);

                entity.Property(e => e.UsuarioAutorizacionId).HasMaxLength(50);

                entity.Property(e => e.UsuarioBloqueoId).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Inventario)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventario_Usuario");

                entity.HasOne(d => d.Estacion)
                    .WithMany(p => p.Inventario)
                    .HasForeignKey(d => d.EstacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventario_Estacion");

                entity.HasOne(d => d.TipoInventarioNavigation)
                    .WithMany(p => p.Inventario)
                    .HasForeignKey(d => d.TipoInventarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventario_TipoInventario");
            });

            modelBuilder.Entity<Inventariop>(entity =>
            {
                entity.Property(e => e.Caducidad).HasColumnType("datetime");

                entity.Property(e => e.Costo).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CostoParcial).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(250);

                entity.Property(e => e.Diferencia).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ExistenciaFisica).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ExistenciaTeorica).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NoLote)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductoId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ResponsableAdicion)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Inventario)
                    .WithMany(p => p.Inventariop)
                    .HasForeignKey(d => d.InventarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventariop_Inventario");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.Property(e => e.ComandoSql)
                    .IsRequired()
                    .HasColumnName("ComandoSQL");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.FechaEjecucion).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(550);

                entity.Property(e => e.Rtf)
                    .IsRequired()
                    .HasColumnName("RTF");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Jobp>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(550);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Jobs>(entity =>
            {
                entity.HasKey(e => e.Id1)
                    .HasName("PK__Jobs__3214EC07B8AF8D93");

                entity.Property(e => e.Id1)
                    .HasColumnName("Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.DueTime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Type).IsRequired();

                entity.Property(e => e.UpdatedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Kardex>(entity =>
            {
                entity.Property(e => e.Caducidad).HasColumnType("datetime");

                entity.Property(e => e.CantEntrada).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CantGlobal).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CantSalida).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ClienteId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ConceptoMovInvId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Costo).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(550);

                entity.Property(e => e.Estacionid)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Max).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Min).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NoLote)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductoId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProveedorId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StockRestante).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UsuarioId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VlEntrada).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.VlGlobal).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.VlSalida).HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<Laboratorio>(entity =>
            {
                entity.HasIndex(e => e.Nombre);

                entity.Property(e => e.LaboratorioId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.EstacionId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JsonClienteFianal).IsRequired();

                entity.Property(e => e.JsonClienteInicial).IsRequired();

                entity.Property(e => e.JsonClientesMismaTarjeta).IsRequired();

                entity.Property(e => e.JsonVentasInvolucradas).IsRequired();

                entity.Property(e => e.LoggedUserId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Lote>(entity =>
            {
                entity.Property(e => e.Caducidad).HasColumnType("datetime");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.NoLote)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductoId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReferenciaString)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StockInicial).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StockRestante).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.Lote)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Lote_Producto1");
            });

            modelBuilder.Entity<LoteVentap>(entity =>
            {
                entity.HasKey(e => e.LotepId);

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.NoLote)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductoId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Lote)
                    .WithMany(p => p.LoteVentap)
                    .HasForeignKey(d => d.LoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LoteVentap_Lote");

                entity.HasOne(d => d.Venta)
                    .WithMany(p => p.LoteVentap)
                    .HasForeignKey(d => d.VentaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LoteVentap_Venta");
            });

            modelBuilder.Entity<Lxc>(entity =>
            {
                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.MotivoCancelacionId);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(500);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ListType).HasMaxLength(3);

                entity.Property(e => e.MotivoCancelacionId).HasMaxLength(3);

                entity.Property(e => e.PaymentCurrency).HasMaxLength(500);

                entity.Property(e => e.PaymentCurrencyId).HasMaxLength(500);

                entity.Property(e => e.PaymentSubTotal).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PaymentTaxes).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PaymentTotal).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PaymentWay).HasMaxLength(500);

                entity.Property(e => e.PaymentWayCode).HasMaxLength(50);

                entity.Property(e => e.RealPayment).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StatusId).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UuidSustitucion).HasMaxLength(50);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Lxc)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.MotivoCancelacion)
                    .WithMany(p => p.Lxc)
                    .HasForeignKey(d => d.MotivoCancelacionId);
            });

            modelBuilder.Entity<LxcDocument>(entity =>
            {
                entity.HasIndex(e => e.CxcId);

                entity.HasIndex(e => e.LxcId);

                entity.HasIndex(e => e.SaleId);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.DocumentBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DocumentOrigin).HasMaxLength(50);

                entity.Property(e => e.DocumentSubTotal).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DocumentTaxes).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DocumentTotal).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DocumentType).HasMaxLength(50);

                entity.Property(e => e.StatusId).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Cxc)
                    .WithMany(p => p.LxcDocument)
                    .HasForeignKey(d => d.CxcId);

                entity.HasOne(d => d.Lxc)
                    .WithMany(p => p.LxcDocument)
                    .HasForeignKey(d => d.LxcId);

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.LxcDocument)
                    .HasForeignKey(d => d.SaleId);
            });

            modelBuilder.Entity<MergeTemplates>(entity =>
            {
                entity.HasKey(e => e.MergeTemplateId);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<MessageUsers>(entity =>
            {
                entity.HasKey(e => new { e.MessageId, e.UsuarioId });

                entity.HasIndex(e => e.UsuarioId);

                entity.Property(e => e.UsuarioId).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.IsReaded)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.MessageUsers)
                    .HasForeignKey(d => d.MessageId);

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.MessageUsers)
                    .HasForeignKey(d => d.UsuarioId);
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<MigrationField>(entity =>
            {
                entity.Property(e => e.Campo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Expresion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UpdateBy).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.MigrationTable)
                    .WithMany(p => p.MigrationField)
                    .HasForeignKey(d => d.MigrationTableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MigrationField_MigrationTable");
            });

            modelBuilder.Entity<MigrationTable>(entity =>
            {
                entity.Property(e => e.Condicion).HasMaxLength(550);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Tabla)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UltSincronizacion).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Moneda>(entity =>
            {
                entity.Property(e => e.MonedaId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<MotivoCancelacion>(entity =>
            {
                entity.Property(e => e.MotivoCancelacionId)
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Orientacion).HasMaxLength(300);

                entity.Property(e => e.TipDelDesarrollador).HasMaxLength(500);
            });

            modelBuilder.Entity<MovInv>(entity =>
            {
                entity.Property(e => e.Caducidad).HasColumnType("datetime");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ClienteId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ConceptoMovsInvId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Costopp).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Es)
                    .IsRequired()
                    .HasColumnName("ES")
                    .HasMaxLength(1);

                entity.Property(e => e.EstacionId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaOperacion).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.NoLote)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrecioVta).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ProductoId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProveedorId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StockAlMomento).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UltimoCosto).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.Valor).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.ConceptoMovsInv)
                    .WithMany(p => p.MovInv)
                    .HasForeignKey(d => d.ConceptoMovsInvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovsInv_ConceptoMovInv");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MovInv)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovInv_Usuario");
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.HasKey(e => e.MucipioId);

                entity.Property(e => e.MucipioId).ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Nombre).HasMaxLength(120);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.Municipio)
                    .HasForeignKey(d => d.EstadoId)
                    .HasConstraintName("FK_Municipio_Estado");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.Property(e => e.PaisId).ValueGeneratedNever();

                entity.Property(e => e.Codigo).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Nombre).HasMaxLength(120);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Permiso>(entity =>
            {
                entity.Property(e => e.PermisoId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.Property(e => e.Amaterno).HasMaxLength(50);

                entity.Property(e => e.Aparterno).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Presentacion>(entity =>
            {
                entity.Property(e => e.PresentacionId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasIndex(e => e.Descripcion);

                entity.Property(e => e.ProductoId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AlmacenId).HasMaxLength(50);

                entity.Property(e => e.CategoriaId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'SYS')");

                entity.Property(e => e.ClaveProdServId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'01010101')");

                entity.Property(e => e.ClaveUnidadId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'H87')");

                entity.Property(e => e.Contenido)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Costopp)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CratedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CratedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(300);

                entity.Property(e => e.Impuesto1Id)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'SYS')");

                entity.Property(e => e.Impuesto2Id)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'SYS')");

                entity.Property(e => e.Impuesto3Id)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'SYS')");

                entity.Property(e => e.LaboratorioId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'SYS')");

                entity.Property(e => e.LoteId)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Max).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Min).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Ocupado).HasDefaultValueSql("((0))");

                entity.Property(e => e.Precio1)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Precio2)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Precio3)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Precio4)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PrecioCaja)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PrecioCompra)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PresentacionId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'SYS')");

                entity.Property(e => e.RutaImg)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Stock).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UltimoCosto)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UnidadMedidaId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'SYS')");

                entity.Property(e => e.Unidades).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.Utilidad1)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Utilidad2)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Utilidad3)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Utilidad4)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ValorStock).HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.Categoria)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.CategoriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Producto_Categoria");

                entity.HasOne(d => d.Impuesto1)
                    .WithMany(p => p.ProductoImpuesto1)
                    .HasForeignKey(d => d.Impuesto1Id)
                    .HasConstraintName("FK_Producto_Impuesto");

                entity.HasOne(d => d.Impuesto2)
                    .WithMany(p => p.ProductoImpuesto2)
                    .HasForeignKey(d => d.Impuesto2Id)
                    .HasConstraintName("FK_Producto_Impuesto1");

                entity.HasOne(d => d.Impuesto3)
                    .WithMany(p => p.ProductoImpuesto3)
                    .HasForeignKey(d => d.Impuesto3Id)
                    .HasConstraintName("FK_Producto_Impuesto2");

                entity.HasOne(d => d.Laboratorio)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.LaboratorioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Producto_Laboratorio");

                entity.HasOne(d => d.Presentacion)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.PresentacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Producto_Presentacion");

                entity.HasOne(d => d.UnidadMedida)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.UnidadMedidaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Producto_UnidadMedida");
            });

            modelBuilder.Entity<ProductoAlmacen>(entity =>
            {
                entity.HasKey(e => new { e.ProductoId, e.AlmacenId });

                entity.HasIndex(e => e.AlmacenId);

                entity.Property(e => e.ProductoId).HasMaxLength(50);

                entity.Property(e => e.AlmacenId).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Maximo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Minimo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Stock).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StockPromedio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StockReservado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UltimoCosto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.ValorStock).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Almacen)
                    .WithMany(p => p.ProductoAlmacen)
                    .HasForeignKey(d => d.AlmacenId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.ProductoAlmacen)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductoProveedor>(entity =>
            {
                entity.HasKey(e => new { e.ProductoId, e.ProveedorId });

                entity.HasIndex(e => e.ProveedorId);

                entity.Property(e => e.ProductoId).HasMaxLength(50);

                entity.Property(e => e.ProveedorId).HasMaxLength(50);

                entity.Property(e => e.CodigoProveedor)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.ProductoProveedor)
                    .HasForeignKey(d => d.ProductoId);

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.ProductoProveedor)
                    .HasForeignKey(d => d.ProveedorId);
            });

            modelBuilder.Entity<ProductoSustancia>(entity =>
            {
                entity.HasKey(e => new { e.ProductoId, e.SustanciaId })
                    .HasName("PK_SustanciaProducto");

                entity.Property(e => e.ProductoId).HasMaxLength(50);

                entity.Property(e => e.SustanciaId).HasMaxLength(50);

                entity.Property(e => e.Contenido).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.ProductoSustancia)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SustanciaProducto_Producto");

                entity.HasOne(d => d.Sustancia)
                    .WithMany(p => p.ProductoSustancia)
                    .HasForeignKey(d => d.SustanciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SustanciaProducto_Sustancia");
            });

            modelBuilder.Entity<ProductoUbicacion>(entity =>
            {
                entity.HasKey(e => new { e.ProductoId, e.UbicacionId });

                entity.HasIndex(e => e.UbicacionId);

                entity.Property(e => e.ProductoId).HasMaxLength(50);

                entity.Property(e => e.UbicacionId).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.ProductoUbicacion)
                    .HasForeignKey(d => d.ProductoId);

                entity.HasOne(d => d.Ubicacion)
                    .WithMany(p => p.ProductoUbicacion)
                    .HasForeignKey(d => d.UbicacionId);
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasIndex(e => e.Negocio);

                entity.HasIndex(e => e.RazonSocial);

                entity.Property(e => e.ProveedorId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Celular).HasMaxLength(100);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Estado).HasMaxLength(100);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.LimiteCredito).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Localidad).HasMaxLength(100);

                entity.Property(e => e.Municipio).HasMaxLength(100);

                entity.Property(e => e.Negocio).HasMaxLength(300);

                entity.Property(e => e.Pais).HasMaxLength(100);

                entity.Property(e => e.RazonSocial).HasMaxLength(300);

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("RFC")
                    .HasMaxLength(13);

                entity.Property(e => e.Saldo).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Telefono).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Punto>(entity =>
            {
                entity.Property(e => e.AbonadoRetirado)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Base).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClienteId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ClienteName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ResetedBy).HasMaxLength(50);

                entity.Property(e => e.Tasa).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Punto)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Punto_Cliente");

                entity.HasOne(d => d.Venta)
                    .WithMany(p => p.Punto)
                    .HasForeignKey(d => d.VentaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Punto_Venta");
            });

            modelBuilder.Entity<PuntoConfig>(entity =>
            {
                entity.HasKey(e => e.PuntosConfigId)
                    .HasName("PK_Monedero");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.TasaDescuento).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Query>(entity =>
            {
                entity.Property(e => e.QueryId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Sql).HasColumnName("SQL");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Reporte>(entity =>
            {
                entity.HasIndex(e => e.Nombre)
                    .HasName("NameUnique")
                    .IsUnique();

                entity.Property(e => e.Codigo).IsRequired();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(550);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rtf)
                    .IsRequired()
                    .HasColumnName("RTF");

                entity.Property(e => e.SecuenciaCifrado)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sql).IsRequired();

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<RolePermiso>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.Permisoid });

                entity.Property(e => e.RoleId).HasMaxLength(50);

                entity.Property(e => e.Permisoid).HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("date");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Permiso)
                    .WithMany(p => p.RolePermiso)
                    .HasForeignKey(d => d.Permisoid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolePermiso_Permiso");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePermiso)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolePermiso_Role");
            });

            modelBuilder.Entity<SatExecutionType>(entity =>
            {
                entity.Property(e => e.SatExecutionTypeId)
                    .HasMaxLength(1)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<SatFile>(entity =>
            {
                entity.HasIndex(e => e.EmpresaId);

                entity.Property(e => e.CompanyName).HasMaxLength(200);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.FileClass).HasMaxLength(5);

                entity.Property(e => e.FileNumber).HasMaxLength(100);

                entity.Property(e => e.Type).HasMaxLength(25);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Empresa)
                    .WithMany(p => p.SatFile)
                    .HasForeignKey(d => d.EmpresaId);
            });

            modelBuilder.Entity<SatOrder>(entity =>
            {
                entity.HasIndex(e => e.SatExecutionTypeId);

                entity.Property(e => e.Comments).HasMaxLength(300);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedIn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.EmitterTin).HasMaxLength(13);

                entity.Property(e => e.ExecutedIn).HasMaxLength(50);

                entity.Property(e => e.ReceiverTin).HasMaxLength(13);

                entity.Property(e => e.RequestUuid).HasMaxLength(50);

                entity.Property(e => e.RequesterTin)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.Property(e => e.SatExecutionTypeId)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Situation).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.SatExecutionType)
                    .WithMany(p => p.SatOrder)
                    .HasForeignKey(d => d.SatExecutionTypeId);
            });

            modelBuilder.Entity<SatPackage>(entity =>
            {
                entity.HasIndex(e => e.SatResponseId);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.PackageUuid).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.SatResponse)
                    .WithMany(p => p.SatPackage)
                    .HasForeignKey(d => d.SatResponseId);
            });

            modelBuilder.Entity<SatRequest>(entity =>
            {
                entity.HasIndex(e => e.SatOrderId);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.RawRequest).IsRequired();

                entity.Property(e => e.Step)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.SatOrder)
                    .WithMany(p => p.SatRequest)
                    .HasForeignKey(d => d.SatOrderId);
            });

            modelBuilder.Entity<SatResponse>(entity =>
            {
                entity.HasIndex(e => e.SatOrderId);

                entity.Property(e => e.CodeStatusRequest).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.QtyCfdi).HasMaxLength(50);

                entity.Property(e => e.RequestUuid).HasMaxLength(50);

                entity.Property(e => e.ResponseStatusCode).HasMaxLength(50);

                entity.Property(e => e.ResponseStatusMessage).HasMaxLength(50);

                entity.Property(e => e.Situation).HasMaxLength(50);

                entity.Property(e => e.Step).HasMaxLength(50);

                entity.Property(e => e.Token).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.SatOrder)
                    .WithMany(p => p.SatResponse)
                    .HasForeignKey(d => d.SatOrderId);
            });

            modelBuilder.Entity<SatXml>(entity =>
            {
                entity.HasIndex(e => e.InvoiceDate);

                entity.HasIndex(e => e.InvoiceNumber);

                entity.HasIndex(e => e.InvoiceSupplierRfc);

                entity.HasIndex(e => e.SatPackageId);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.InvoiceCustomer).HasMaxLength(300);

                entity.Property(e => e.InvoiceCustomerRfc).HasMaxLength(13);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(100);

                entity.Property(e => e.InvoiceSeries).HasMaxLength(100);

                entity.Property(e => e.InvoiceSubTotal).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InvoiceSupplier).HasMaxLength(300);

                entity.Property(e => e.InvoiceSupplierRfc).HasMaxLength(13);

                entity.Property(e => e.InvoiceTotal).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InvoiceType).HasMaxLength(1);

                entity.Property(e => e.InvoiceUuid).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.SatPackage)
                    .WithMany(p => p.SatXml)
                    .HasForeignKey(d => d.SatPackageId);
            });

            modelBuilder.Entity<SatXmlItem>(entity =>
            {
                entity.HasIndex(e => e.SatXmlId);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NoIdentification).HasMaxLength(150);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TaProductCode).HasMaxLength(50);

                entity.Property(e => e.TaUnitCode).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.SatXml)
                    .WithMany(p => p.SatXmlItem)
                    .HasForeignKey(d => d.SatXmlId);
            });

            modelBuilder.Entity<Sector>(entity =>
            {
                entity.HasIndex(e => e.AlmacenId);

                entity.HasIndex(e => e.CentroCostoId);

                entity.HasIndex(e => e.Nombre);

                entity.Property(e => e.SectorId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AlmacenId).HasMaxLength(50);

                entity.Property(e => e.CentroCostoId).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Almacen)
                    .WithMany(p => p.Sector)
                    .HasForeignKey(d => d.AlmacenId);

                entity.HasOne(d => d.CentroCosto)
                    .WithMany(p => p.Sector)
                    .HasForeignKey(d => d.CentroCostoId);
            });

            modelBuilder.Entity<Sucursal>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Sustancia>(entity =>
            {
                entity.HasIndex(e => e.Nombre);

                entity.Property(e => e.SustanciaId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("test");

                entity.HasIndex(e => e.Nombre)
                    .HasName("IX_test")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<TipoDoc>(entity =>
            {
                entity.Property(e => e.TipoDocId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<TipoInventario>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Traspaso>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Documento).HasMaxLength(50);

                entity.Property(e => e.EstadoDocId).HasMaxLength(5);

                entity.Property(e => e.FechaDocumento).HasColumnType("datetime");

                entity.Property(e => e.Impuesto).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SentBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SerieDestino)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.SerieOrigen)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SucursalDestinoName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SucursalOrigenName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoDocId).HasMaxLength(5);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Traspaso)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Traspaso_Usuario");

                entity.HasOne(d => d.SucursalDestino)
                    .WithMany(p => p.TraspasoSucursalDestino)
                    .HasForeignKey(d => d.SucursalDestinoId)
                    .HasConstraintName("FK_Traspaso_Sucursal1");

                entity.HasOne(d => d.SucursalOrigen)
                    .WithMany(p => p.TraspasoSucursalOrigen)
                    .HasForeignKey(d => d.SucursalOrigenId)
                    .HasConstraintName("FK_Traspaso_Sucursal");
            });

            modelBuilder.Entity<Traspasop>(entity =>
            {
                entity.Property(e => e.Caducidad).HasColumnType("datetime");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).IsRequired();

                entity.Property(e => e.ImporteImpuesto1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImporteImpuesto2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Impuesto1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Impuesto2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ImpuestoId1).HasMaxLength(50);

                entity.Property(e => e.ImpuestoId2).HasMaxLength(50);

                entity.Property(e => e.NoLote).HasMaxLength(50);

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductoId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Stock).HasColumnType("decimal(18, 1)");

                entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Traspaso)
                    .WithMany(p => p.Traspasop)
                    .HasForeignKey(d => d.TraspasoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Traspasop_Traspaso");
            });

            modelBuilder.Entity<Ubicacion>(entity =>
            {
                entity.HasIndex(e => e.Camino);

                entity.HasIndex(e => e.Descripcion);

                entity.HasIndex(e => e.UbicacionSuperiorId);

                entity.Property(e => e.UbicacionId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Camino)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UbicacionSuperiorId).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.UbicacionSuperior)
                    .WithMany(p => p.InverseUbicacionSuperior)
                    .HasForeignKey(d => d.UbicacionSuperiorId);
            });

            modelBuilder.Entity<UnidadMedida>(entity =>
            {
                entity.Property(e => e.UnidadMedidaId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.UnidadSat).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasIndex(e => e.Nombre);

                entity.HasIndex(e => e.SectorId);

                entity.Property(e => e.UsuarioId)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.AllowPurchasesFromXml)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.AllowsElectronicWalletManagement)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.EstacionId).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PuedeGestionarCxc)
                    .IsRequired()
                    .HasColumnName("PuedeGestionarCXC")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.PuendeLanzarPdv)
                    .IsRequired()
                    .HasColumnName("PuendeLanzarPDV")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.SectorId).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.SectorId);
            });

            modelBuilder.Entity<UsuarioRole>(entity =>
            {
                entity.HasKey(e => new { e.UsuarioId, e.RoleId });

                entity.Property(e => e.UsuarioId).HasMaxLength(50);

                entity.Property(e => e.RoleId).HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("date");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UsuarioRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsuarioRole_Role");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.UsuarioRole)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsuarioRole_Usuario");
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasIndex(e => e.MotivoCancelacionId);

                entity.Property(e => e.Anio).HasDefaultValueSql("(CONVERT([smallint],(0)))");

                entity.Property(e => e.Anulada).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cambio).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ClienteId)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'SYS')");

                entity.Property(e => e.ConceptoPago1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'EFECTIVO')");

                entity.Property(e => e.ConceptoPago2).HasMaxLength(50);

                entity.Property(e => e.ConceptoPago3).HasMaxLength(50);

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DatosCliente).HasDefaultValueSql("(N'SYS')");

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.DescXpuntos).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Descuento)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EsCxc).HasDefaultValueSql("((0))");

                entity.Property(e => e.EstacionId)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'ESTACION01')");

                entity.Property(e => e.EstadoDocId)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'PEN')");

                entity.Property(e => e.EstatusSat)
                    .HasColumnName("EstatusSAT")
                    .HasMaxLength(50);

                entity.Property(e => e.ExtensionArchivoSoporteDocumental).HasMaxLength(10);

                entity.Property(e => e.FechaDoc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaSistema)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaTimbrado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormaPago1)
                    .HasMaxLength(2)
                    .HasDefaultValueSql("(N'01')");

                entity.Property(e => e.FormaPago2).HasMaxLength(2);

                entity.Property(e => e.FormaPago3).HasMaxLength(2);

                entity.Property(e => e.Impuesto).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Mes).HasMaxLength(2);

                entity.Property(e => e.MetodoPago).HasMaxLength(50);

                entity.Property(e => e.MonedaId)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'MXN')");

                entity.Property(e => e.MotivoCancelacionId).HasMaxLength(3);

                entity.Property(e => e.NoCertificado).HasMaxLength(40);

                entity.Property(e => e.NoPrecio).HasDefaultValueSql("((1))");

                entity.Property(e => e.NoRef).HasDefaultValueSql("((0))");

                entity.Property(e => e.Pago1).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Pago2).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Pago3).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Periodicidad).HasMaxLength(2);

                entity.Property(e => e.RutaXml).HasMaxLength(250);

                entity.Property(e => e.SelloCfdi).HasColumnName("SelloCFDI");

                entity.Property(e => e.SelloSat).HasColumnName("SelloSAT");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.SubTotalEsperado).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TipoComprobante)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.TipoDocId)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'TIC')");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Unidades).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UsoCfdi)
                    .HasColumnName("UsoCFDI")
                    .HasMaxLength(5);

                entity.Property(e => e.UuId).HasMaxLength(40);

                entity.Property(e => e.UuidSustitucion).HasMaxLength(50);

                entity.Property(e => e.Xml).HasColumnName("XML");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("FK_Venta_Cliente");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Venta_Usuario");

                entity.HasOne(d => d.Estacion)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.EstacionId)
                    .HasConstraintName("FK_Venta_Estacion");

                entity.HasOne(d => d.MotivoCancelacion)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.MotivoCancelacionId);

                entity.HasOne(d => d.TipoDoc)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.TipoDocId)
                    .HasConstraintName("FK_Venta_TipoDoc");

                entity.HasOne(d => d.UsoCfdiNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.UsoCfdi)
                    .HasConstraintName("Venta_C_Usocfdi_UsoCFDIId_fk");
            });

            modelBuilder.Entity<VentaImpuesto>(entity =>
            {
                entity.HasIndex(e => e.VentaId);

                entity.Property(e => e.Base).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Impuesto)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.ImpuestoId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TasaOcuota)
                    .HasColumnName("TasaOCuota")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TipoFactor)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Venta)
                    .WithMany(p => p.VentaImpuesto)
                    .HasForeignKey(d => d.VentaId);
            });

            modelBuilder.Entity<Ventap>(entity =>
            {
                entity.Property(e => e.Caducidad).HasColumnType("datetime");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ClaveImpuesto1).HasMaxLength(5);

                entity.Property(e => e.ClaveImpuesto2).HasMaxLength(5);

                entity.Property(e => e.ClaveProdServ)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'01010101')");

                entity.Property(e => e.ClaveUnidad)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'H87')");

                entity.Property(e => e.Costo).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(250);

                entity.Property(e => e.Descuento).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ImporteImpuesto1).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ImporteImpuesto2).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Impuesto1).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Impuesto2).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NoLote).HasMaxLength(50);

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(18, 6)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PrecioCaja).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ProductoId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TasaOcuota1).HasMaxLength(50);

                entity.Property(e => e.TasaOcuota2).HasMaxLength(50);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Unidad).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.ClaveImpuesto1Navigation)
                    .WithMany(p => p.VentapClaveImpuesto1Navigation)
                    .HasForeignKey(d => d.ClaveImpuesto1)
                    .HasConstraintName("Ventap_C_Impuesto_ImpuestoId_fk");

                entity.HasOne(d => d.ClaveImpuesto2Navigation)
                    .WithMany(p => p.VentapClaveImpuesto2Navigation)
                    .HasForeignKey(d => d.ClaveImpuesto2)
                    .HasConstraintName("Ventap_C_Impuesto_ImpuestoId_fk_2");

                entity.HasOne(d => d.Venta)
                    .WithMany(p => p.Ventap)
                    .HasForeignKey(d => d.VentaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ventap_Venta");
            });

            modelBuilder.Entity<VentapImpuesto>(entity =>
            {
                entity.HasIndex(e => e.VentapId);

                entity.Property(e => e.Base).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Impuesto)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.ImpuestoId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TasaOcuota)
                    .HasColumnName("TasaOCuota")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TipoFactor)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.HasOne(d => d.Ventap)
                    .WithMany(p => p.VentapImpuesto)
                    .HasForeignKey(d => d.VentapId);
            });

            modelBuilder.Entity<Vlu>(entity =>
            {
                entity.ToTable("VLU");

                entity.Property(e => e.Vluid).HasColumnName("VLUId");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DeletedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            });
        }
    }
}