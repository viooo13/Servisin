# Servisin - UI/UX Design System & Prompt Blueprint

## 1. Design System Overview

**Servisin** mengadopsi gaya desain SaaS B2B modern yang berfokus pada efisiensi teknisi dan kenyamanan pelanggan. Antarmuka memadukan tata letak yang padat data (*data-dense*) untuk manajemen bengkel dengan pengalaman minimalis untuk portal pelanggan.

### 1.1 Color Palette
*   **Primary Background:** Pure White (`#FFFFFF`) & Light Slate.
*   **Navigation & Sidebar:** Deep Dark Navy Blue (`#0F172A`).
*   **Text & Typography:** High-contrast Dark Navy untuk teks utama.
*   **Accent & Urgency:** Warm-to-dark fire ripple gradient (transisi oranye menyala ke merah gelap) digunakan secara eksklusif untuk indikator *overdue*, peringatan stok tipis, dan persetujuan biaya tambahan.

### 1.2 Typography
*   **Data & Body:** Geometric Sans-Serif (Inter / Roboto) untuk keterbacaan tabel dan form.
*   **Display & Highlight:** Bold, dramatic custom typography untuk elemen hero, sapaan, dan ID Tiket (misal: **#TKT-992**).

### 1.3 Tech Stack Implementation
Desain ini sangat dioptimalkan untuk implementasi *fullstack* di ekosistem .NET menggunakan:
*   **Framework:** ASP.NET Core (Razor Pages / MVC / Blazor) & C#.
*   **Database:** SQLite menggunakan library `Microsoft.EntityFrameworkCore.Sqlite`.
*   **Templating:** Razor Syntax (`.cshtml` atau `.razor`) untuk memecah UI menjadi komponen atau *Partial Views* yang *reusable* (seperti `_Sidebar.cshtml` atau `<KanbanCard />`).
*   **Styling:** Tailwind CSS (sangat mudah diintegrasikan langsung ke dalam *class* HTML di file Razor untuk menghasilkan UI yang presisi sesuai desain).

---

## 2. SuperAdmin Portal (SaaS Management)

Halaman khusus untuk pemilik aplikasi (Pio) memantau keseluruhan bisnis SaaS, klien, dan kesehatan server.

### 2.1 System & Tenant Dashboard
**Fokus:** Memantau klien (bengkel) dan beban server.
> **Prompt (Figma/AI Generator):**
> High-fidelity UI design of a SuperAdmin SaaS Dashboard. Deep Dark Navy sidebar with items: Overview, Tenants, Billing, System Health. Main workspace is Pure White. Top metric cards: "Total Active Shops", "Monthly MRR", "AI API Usage", "SQLite DB Size". Below is a data table of "Registered Tenants" showing Shop Name, Subscription Plan, Status (Active/Suspended), and Action buttons. Professional enterprise SaaS aesthetic, Tailwind CSS styling.

---

## 3. Admin & Technician Portal (B2B Dashboard)

Sistem navigasi menggunakan *Left Sidebar* berwarna Dark Navy dengan area kerja utama Pure White. Pendekatan ini sangat cocok menggunakan ASP.NET Core Layout (`_Layout.cshtml`).

### 3.1 Dashboard Overview
**Fokus:** Metrik operasional harian.
> **Prompt (Figma/AI Generator):**
> High-fidelity UI design of a B2B SaaS Dashboard for "Servisin". Deep Dark Navy left sidebar with the following menu items: Dashboard (active), Smart Kanban, Inventory, AI Triage Logs, Settings. Main content area has a Pure White background. Top content features 4 metric cards: "Active Tickets", "Today's Revenue", "Low Stock Parts", and "AI Success Rate". Below the cards, a wide data table titled "Recent AI Triage Requests" showing columns: Date, Customer Name, Device Model (extracted by AI), Estimated Cost, and a status badge (Pending/Approved). Clean, modern, highly readable geometric sans-serif font.

### 3.2 Smart Kanban Workspace
**Fokus:** Manajemen status perbaikan *drag-and-drop*.
> **Prompt (Figma/AI Generator):**
> High-fidelity UI design of a Smart Kanban Board for tech repair. Deep Dark Navy sidebar. The main workspace (Pure White background) contains exactly 4 vertical columns: "Queue", "Checking", "Waiting Parts", "In Progress". Inside the "Queue" column, there are clean white Kanban cards. Each card displays: a prominent Ticket ID (e.g., #TKT-882) using bold dramatic custom typography, Device Name (e.g., iPhone 13), a thumbnail photo of the physical damage, and AI tags ("Screen", "Battery"). One card in the "In Progress" column is overdue and features a warm-to-dark fire ripple gradient border to indicate high urgency. Crisp layout, intuitive drag-and-drop aesthetic.

### 3.3 Inventory Management
**Fokus:** Kontrol stok suku cadang dan harga dasar untuk kalkulasi AI.
> **Prompt (Figma/AI Generator):**
> High-fidelity UI design of an Inventory Management page. Dark Navy sidebar. Pure white main workspace. At the top right, a prominent Dark Navy button labeled "+ Add Spare Part". The core content is a clean, spacious data table with the following columns: "Part ID", "Item Name", "Category" (Screen, Battery, IC), "Stock Level", "Base Price", and "Actions" (Edit/Delete icons). Rows with stock levels below 5 are highlighted with a subtle warm orange alert icon. Minimalist enterprise UI, clear grid alignments, optimized for Razor components and Tailwind CSS rendering.

---

## 4. Customer Portal (B2C Dashboard)

Berbeda dengan admin, *dashboard* pelanggan lebih berfokus pada ketenangan pikiran (*peace of mind*), pelacakan status, dan riwayat perangkat.

### 4.1 Customer Overview & Active Tracking
**Fokus:** Ringkasan perangkat yang sedang diservis dan tombol aksi cepat.
> **Prompt (Figma/AI Generator):**
> High-fidelity UI design of a Customer Portal Dashboard for a gadget repair platform named "Servisin". Desktop web view. Deep Dark Navy left sidebar with navigation icons: Overview, Active Repairs, Service History, Profile. The main workspace has a Pure White background. At the top, a clean, bold custom typography greeting reading "Welcome back". Below it, a large featured card titled "Current Active Repair" showing an iPhone 13 Pro Max with a horizontal Live Tracking timeline indicating "In Progress". Next to it, a prominent Dark Navy floating-style card with a "Start New AI Triage" Call-to-Action button. Spacious, minimalist SaaS UI, Dribbble trending.

### 4.2 Action Required (Urgent Notification)
**Fokus:** Meminta persetujuan pelanggan jika teknisi menemukan kerusakan baru.
> **Prompt (Figma/AI Generator):**
> High-fidelity UI design of a Customer Dashboard active repair page. Desktop view. Deep Dark Navy sidebar, Pure White main content area. The center features a prominent "Action Required" notification card with a subtle warm-to-dark fire ripple gradient border to indicate urgency. The card displays: "Additional Issue Found: Battery Swollen", "Extra Cost: Rp 150.000". Inside the card are two clear buttons: a primary Dark Navy button "Approve & Continue" and a secondary white outline button "Decline". Clean geometric sans-serif typography, highly readable, premium tech aesthetic.

### 4.3 Service History & Invoices
**Fokus:** Riwayat perbaikan masa lalu dan total biaya.
> **Prompt (Figma/AI Generator):**
> High-fidelity UI design of a Service History page for a Customer Dashboard. Desktop view. Deep Dark Navy sidebar. Pure White main content area. A clean, wide data table listing past repairs. Columns include: "Ticket ID" (in bold dramatic typography e.g., #TKT-884), "Device Model", "Completion Date", "Total Cost", and "Invoice" (with a small download icon). The table rows have subtle light gray borders and spacious padding. Minimalist, enterprise-grade user interface, high contrast, organized and highly functional.

### 4.4 Mobile Triage Chat (Entry Point)
**Fokus:** Pendaftaran servis interaktif melalui *mobile view*.
> **Prompt (Figma/AI Generator):**
> High-fidelity mobile UI design of a customer AI triage portal for gadget repair. Deep Dark Navy header with shop logo. Pure white background chat interface. Bottom input field has a prominent "Camera" icon for multimodal vision upload. The chat history shows a user uploading a photo of a cracked smartphone. The AI replies with a clean white card featuring a thin Dark Navy border, displaying structured text: "Detected Issue: Shattered Screen", "Est. Cost: Rp 450.000 - Rp 600.000". Below the text is a bold Dark Navy primary button labeled "Book Repair". Minimalist, trustworthy tech aesthetic, clean whitespace.

### 4.5 Live Tracking Timeline
**Fokus:** Pemantauan status *real-time* via SignalR di layar HP pelanggan.
> **Prompt (Figma/AI Generator):**
> High-fidelity mobile UI design of a live tracking page. Pure white background. A large Ticket ID at the top in bold dramatic typography. A vertical timeline with 4 milestones. The active step has a pulsing Dark Navy dot. A floating bottom card shows "Current Action: Replacing LCD". Reassuring UX, high contrast.