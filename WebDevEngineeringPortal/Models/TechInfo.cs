namespace DevEngineeringHub.Models
{
    // Clase C# para estructurar la información técnica de ingeniería
    public class TechLanguage
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty; // Frontend / Backend
        public string AcronymMeaning { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string FullDescription { get; set; } = string.Empty;
        public string PrimaryFunctions { get; set; } = string.Empty;
        public List<string> EngineeringFeatures { get; set; } = new List<string>();
        public string ImageUrl { get; set; } = string.Empty;
    }

    public static class TechRepository
    {
        public static List<TechLanguage> GetEngineeringTechData()
        {
            return new List<TechLanguage>
            {
                new TechLanguage
                {
                    Id = "html",
                    Name = "HTML5",
                    Category = "Frontend",
                    AcronymMeaning = "HyperText Markup Language (Lenguaje de Marcado de Hipertexto)",
                    ShortDescription = "Estructura semántica básica y esqueleto fundamental para aplicaciones web.",
                    FullDescription = "HTML es el estándar fundamental en la ingeniería web encargada de definir el esqueleto y la arquitectura semántica del documento. Permite maquetar contenidos estructurados como encabezados, listas, formularios y secciones que los navegadores web interpretan para el usuario final.",
                    PrimaryFunctions = "Estructuración semántica, maquetación de componentes visuales, integración de elementos multimedia y accesibilidad web.",
                    EngineeringFeatures = new List<string> { "Soporte Semántico de HTML5", "Integración con DOM API", "Optimización SEO On-Page", "Estructura para lectura por Screen Readers" },
                    ImageUrl = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/html5/html5-original.svg"
                },
                new TechLanguage
                {
                    Id = "css",
                    Name = "CSS3",
                    Category = "Frontend",
                    AcronymMeaning = "Cascading Style Sheets (Hojas de Estilo en Cascada)",
                    ShortDescription = "Diseño visual, maquetación adaptativa (Responsive) y estilizado de interfaces.",
                    FullDescription = "CSS es el motor de estilizado e interfaz en la web. Permite aplicar reglas de diseño, animaciones, gradientes, Flexbox, Grid y principios de diseño adaptativo a la estructura HTML, separando completamente la capa de presentación de la capa de estructura.",
                    PrimaryFunctions = "Estilizado visual, maquetación adaptativa (Responsive Web Design), animaciones, gestión de layouts avanzados y diseño modular.",
                    EngineeringFeatures = new List<string> { "CSS Grid & Flexbox Engines", "Custom Properties (Variables CSS)", "Animaciones e Interacciones a 60fps", "Soporte de Media Queries" },
                    ImageUrl = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/css3/css3-original.svg"
                },
                new TechLanguage
                {
                    Id = "js",
                    Name = "JavaScript",
                    Category = "Frontend / Fullstack",
                    AcronymMeaning = "JS (Lenguaje de Programación Interpretado Multi-paradigma)",
                    ShortDescription = "Lógica dinámicas en tiempo real, manipulación del DOM e interactividad client-side.",
                    FullDescription = "JavaScript es el lenguaje de programación estándar para el desarrollo web cliente. Permite convertir sitios estáticos en aplicaciones dinámicas e interactivas mediante el manejo de eventos, consumo de APIs REST, manipulación del DOM y procesamiento asíncrono.",
                    PrimaryFunctions = "Lógica client-side, manipulación asíncrona mediante Fetch API / Promises, procesamiento de eventos e interacción dinámica con el usuario.",
                    EngineeringFeatures = new List<string> { "Manejo de Asincronía (Async/Await)", "Manipulación dinámica del DOM", "Navegación Single Page (SPA)", "Event Loop & Non-Blocking I/O" },
                    ImageUrl = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/javascript/javascript-original.svg"
                },
                new TechLanguage
                {
                    Id = "csharp",
                    Name = "C# (.NET 8/9)",
                    Category = "Backend / Enterprise",
                    AcronymMeaning = "C-Sharp (Lenguaje Orientado a Objetos de Alto Rendimiento para .NET)",
                    ShortDescription = "Arquitectura backend robusta, microservicios, APIs RESTful y lógica empresarial segura.",
                    FullDescription = "C# es un lenguaje multiparadigma fuertemente tipado diseñado por Microsoft para la plataforma .NET. Ofrece alto rendimiento, tipado estático seguro, compilación JIT/AOT, inyección de dependencias nativa y soporte para microservicios y desarrollo empresarial distribuido.",
                    PrimaryFunctions = "Lógica de negocio robusta, APIs Web RESTful, integración con bases de datos vía Entity Framework Core, autenticación/autorización y procesamiento concurrente.",
                    EngineeringFeatures = new List<string> { "Patrón LINQ (Language Integrated Query)", "Inyección de Dependencias Nativa", "Seguridad de Tipo Fuertemente Tipada", "Rendimiento asíncrono escalable en .NET" },
                    ImageUrl = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg"
                },
                new TechLanguage
                {
                    Id = "angular",
                    Name = "Angular",
                    Category = "Frontend Framework",
                    AcronymMeaning = "Framework Empresarial para Frontend basado en TypeScript",
                    ShortDescription = "Framework SPA para la construcción de plataformas web modulares y escalables.",
                    FullDescription = "Angular es una plataforma y framework de desarrollo cliente basado en TypeScript creado por Google. Está orientado a la arquitectura empresarial SPA (Single Page Application), ofreciendo inyección de dependencias, data binding bidireccional, enrutamiento avanzado y arquitectura por componentes.",
                    PrimaryFunctions = "Desarrollo de Single Page Applications (SPA), arquitectura modular basada en componentes, reactividad con RxJS y gestión de estado escalable.",
                    EngineeringFeatures = new List<string> { "Inyección de Dependencias Frontend", "Basado 100% en TypeScript", "Enrutamiento modular avanzado", "Programación reactiva con RxJS" },
                    ImageUrl = "https://cdn.jsdelivr.net/gh/devicons/devicon/icons/angularjs/angularjs-original.svg"
                }
            };
        }
    }
}
