// Function to generate a random date within the last 30 days
function getRandomDate() {
    const start = new Date();
    start.setDate(start.getDate() - 30);
    const end = new Date();
    const date = new Date(start.getTime() + Math.random() * (end.getTime() - start.getTime()));
    // Format date as YYYY-MM-DD
    return date.toISOString().split('T')[0];
}

// Sample data pools
const nombres = ["Juan", "María", "Carlos", "Ana", "Luis", "Laura", "Pedro", "Sofía", "Miguel", "Elena"];
const apellidos = ["García", "Rodríguez", "Martínez", "Hernández", "López", "González", "Pérez", "Sánchez", "Ramírez", "Torres"];
const motivos = ["Incidencia", "Queja", "Reclamacion", "Sugerencia"];
const sexos = ["Masculino", "Femenino"];

// Function to get random item from an array
const getRandomItem = (arr) => arr[Math.floor(Math.random() * arr.length)];

// Generate 10 random records and make them available globally
const clientesAtendidosData = Array.from({ length: 10 }, () => {
    const nombre = getRandomItem(nombres);
    const apellido = getRandomItem(apellidos);
    return {
        Nombre: nombre,
        Apellidos: apellido,
        TelefonoCelular: `555-${String(Math.floor(1000 + Math.random() * 9000)).padStart(4, '0')}`,
        Email: `${nombre.toLowerCase()}.${apellido.toLowerCase()}@example.com`,
        Sexo: getRandomItem(sexos),
        Motivo: getRandomItem(motivos),
        FechaRegistro: getRandomDate()
    };
});