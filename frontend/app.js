document.addEventListener('DOMContentLoaded', () => {
    const formulario = document.getElementById('formulario-medico');
    const listaMedicos = document.getElementById('lista-medicos');

    
    formulario.addEventListener('submit', async (event) => {
        event.preventDefault();

        const nombre = document.getElementById('nombre').value;

        
        const nuevoMedico = {
            nombre: nombre,
            
        };

      
        const response = await fetch('/api/Medicos/Crear', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(nuevoMedico)
        });

        if (response.ok) {
            alert('Médico creado exitosamente');
          
            formulario.reset();
          
            actualizarListaMedicos();
        } else {
            alert('Error al crear el médico');
        }
    });

    
    async function actualizarListaMedicos() {
       
        const response = await fetch('/api/Medicos/Listar');
        const data = await response.json();

        
        listaMedicos.innerHTML = '';

       
        data.forEach(medico => {
            const item = document.createElement('li');
            item.textContent = medico.nombre; 
            listaMedicos.appendChild(item);
        });
    }

    
    actualizarListaMedicos();
});