//exercicio 05

var mock = [
    {
        titulo: 'Montanha Encantada',
        imagem: './img/montanha.jpg',
        subtitulo: 'Explore a beleza das montanhas com vistas deslumbrantes'
    },
    {
        titulo: 'Praia Paradisíaca',
        imagem: './img/praia.jpg',
        subtitulo: 'Relaxe em praias de águas cristalinas e areias brancas'
    },
    {
        titulo: 'Cidade Histórica',
        imagem: './img/cidade.jpg',
        subtitulo:'Conheça o passado em uma cidade repleta de história e cultura'
    },
    {
        titulo: 'Aventura na Floresta',
        imagem: './img/floresta.jpg',
        subtitulo: 'Explore a natureza selvagem em uma emocionante aventura'
    },
    {
        titulo: 'Viagem de Trem',
        imagem: './img/trem.jpg',
        subtitulo: 'Descubra paisagens únicas a bordo de uma viagem de trem'
    },
    {
        titulo: 'Experiência Gastronômica',
        imagem: './img/experiencia.jpg',
        subtitulo:'Delicie-se com pratos gourmet preparados por chefs renomados'
    },
    {
        titulo: 'Aurora Boreal',
        imagem: './img/aurora.jpg',
        subtitulo: 'Contemple o espetáculo das luzes dançantes no céu noturno'
    },
    {
        titulo: 'Destino Romântico',
        imagem: './img/destino.jpg',
        subtitulo: 'Viva momentos inesquecíveis ao lado da pessoa amada'
    },
    {
        titulo: 'Viagem Cultural',
        imagem: './img/cultural.jpg',
        subtitulo:'Conheça diferentes culturas e tradições em uma viagem enriquecedora'
    }
]

sessionStorage.setItem("mock", JSON.stringify(mock));
const album = document.getElementById("album");

function busca() {
    album.innerHTML = '';
    const recuperado = sessionStorage.getItem("mock");
    const parseado = JSON.parse(recuperado);
    const busca = document.getElementById("busca").value;

    parseado.forEach(element => {
        if (element.titulo.includes(busca) || element.subtitulo.includes(busca)) {
            const div = document.createElement("div");

            const h2 = document.createElement("h2");
            h2.innerHTML = element.titulo;
            div.appendChild(h2);
            

            const img = document.createElement("img");
            img.setAttribute('src', element.imagem)
            div.appendChild(img);
            

            const h3 = document.createElement("h3");
            h3.innerHTML = element.subtitulo;
            div.appendChild(h3);
          

            album.appendChild(div)
        }
    })
}