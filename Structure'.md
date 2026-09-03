# Servisin - Struktur Folder & Fungsionalitas Role

Dokumen ini memetakan arsitektur folder dalam C# ASP.NET Core dan mendefinisikan batasan akses (Role-Based Access Control) dari setiap halaman aplikasi.

## 1. Struktur Folder Proyek (ASP.NET Core MVC / Razor)

```text
Servisin/
├── Servisin.Web/                      # Project Utama (Frontend & Routing)
│   ├── Controllers/                   
│   │   ├── SuperAdminController.cs    # Routing untuk pemilik aplikasi SaaS
│   │   ├── AdminController.cs         # Routing untuk dashboard operasional bengkel
│   │   ├── CustomerController.cs      # Routing untuk portal pelanggan
│   │   └── ApiController.cs           # Endpoint backend untuk Kanban & AI
│   ├── Hubs/                          
│   │   └── TrackingHub.cs             # ASP.NET Core SignalR untuk Live Tracking
│   ├── Views/                         # UI dengan sintaks Razor (.cshtml)
│   │   ├── SuperAdmin/                # Halaman KHUSUS SuperAdmin
│   │   │   ├── Dashboard.cshtml
│   │   │   └── Tenants.cshtml
│   │   ├── Admin/                     # Halaman untuk Role: Admin & Teknisi
│   │   │   ├── Dashboard.cshtml
│   │   │   ├── Kanban.cshtml
│   │   │   └── Inventory.cshtml
│   │   ├── Customer/                  # Halaman untuk Role: Customer
│   │   │   ├── AiTriage.cshtml
│   │   │   ├── Dashboard.cshtml
│   │   │   └── LiveTracking.cshtml
│   │   └── Shared/                    # Komponen Reusable (Razor Layouts)
│   │       ├── _LayoutSuperAdmin.cshtml 
│   │       ├── _LayoutAdmin.cshtml    
│   │       └── _LayoutCustomer.cshtml 
│   ├── wwwroot/                       
│   │   ├── css/tailwind.output.css    # Hasil kompilasi Tailwind CSS
│   │   └── js/signalr-client.js      
│   └── Program.cs                     
│
├── Servisin.Core/                     # Entitas & Model Logika
│   ├── Models/
│   │   ├── Tenant.cs                  # Data Bengkel (Klien SaaS)
│   │   ├── User.cs                    # Akun pengguna
│   │   ├── Ticket.cs                  # Data Servis (terhubung ke TenantId)
│   │   └── SparePart.cs               # Data Inventory (terhubung ke TenantId)
│   └── Enums/
│       └── RoleType.cs                # SuperAdmin, Admin, Technician, Customer
│
├── Servisin.Data/                     # Layer Akses Database SQLite
│   ├── ApplicationDbContext.cs        # Konfigurasi EF Core & Global Query Filters
│   └── Migrations/                    
│
└── Servisin.Services/                 # Logika Bisnis
    ├── AITriageService.cs             # Logika integrasi prompt AI per Tenant
    ├── InventoryService.cs            # Logika pemotongan stok SQLite otomatis
    └── TenantResolverService.cs       # Deteksi TenantId pengguna yang login