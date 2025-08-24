🛋️ C# WinForms 기반 가구 주문 키오스크

이 프로젝트는 C#과 Windows Forms를 사용하여 개발한 가구 주문 키오스크 시뮬레이션 애플리케이션입니다. 사용자는 매장에 비치된 키오스크의 직관적인 UI를 통해 가구 정보를 둘러보고, 원하는 상품을 장바구니에 담아 주문하는 전체 과정을 경험할 수 있습니다.

✨ 주요 기능 (Features)

    제품 카탈로그 및 상세 정보: 카테고리별로 정리된 가구 목록을 탐색하고, 제품 클릭 시 상세 설명, 가격, 이미지를 포함한 자세한 정보를 확인할 수 있습니다.

    장바구니 기능: 원하는 상품을 장바구니에 추가, 수정, 삭제할 수 있으며, 전체 주문 내역과 총 결제 금액을 한눈에 파악할 수 있습니다.

    실시간 수량 및 가격 연동: +와 - 버튼으로 상품 수량을 조절하면, 개별 상품의 합계와 장바구니의 총금액이 실시간으로 자동 계산됩니다.

    화면 간 데이터 관리: 메인 화면, 상세 정보, 장바구니 등 여러 폼(Form)을 오가는 동안 사용자의 선택 데이터가 일관성 있게 유지됩니다.

    사용자 친화적 인터페이스: 복잡한 설명 없이 누구나 쉽게 사용할 수 있도록 직관적인 UI/UX를 구현했습니다.



✨ 프로젝트 구조
📁 Project1/
│
├── 📄 Program.cs                 
├── 📄 Project1.csproj            
│
├── 📁 Models/                     
│   └── 📄 CartData.cs
│
├── 📁 Properties/                
│   └── 📄 AssemblyInfo.cs
│
├── 📁 Resources/                 
│   └── ...
│
└── 📁 Views/                     
    │
    ├── 📁 00_Main/               
    │   ├── 📄 Main1.cs
    │   └── 📄 Search.cs
    │
    ├── 📁 01_User/               
    │   ├── 📄 Login.cs
    │   ├── 📄 Resister.cs
    │   └── 📄 information.cs
    │
    ├── 📁 02_Products/           
    │   ├── 📄 Bed.cs
    │   ├── 📄 Chair.cs
    │   ├── 📄 Table.cs
    │   ├── 📄 Drawer.cs
    │   ├── 📄 Rug.cs
    │   ├── 📄 Blankit.cs
    │   └── ... (기타 모든 상품 폼)
    │
    ├── 📁 03_Order/              
    │   ├── 📄 Count.cs
    │   └── 📄 address.cs
    │
    └── 📁 04_Simulator/          
        └── 📄 Funiture.cs

프로젝트 이미지

ReadMeimg/blanket2img.png

🛠️ 기술 스택 (Tech Stack)

    Language: C#

    Framework: .NET Framework

    UI Platform: Windows Forms

🚀 시작하기 (Getting Started)

다운로드한 폴더에서 Visual Studio 솔루션 파일(.sln)을 엽니다.

실행
Visual Studio에서 F5 키를 누르거나 '시작' 버튼을 클릭하여 프로젝트를 빌드하고 실행합니다.
