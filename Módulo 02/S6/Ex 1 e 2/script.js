fetch("https://servicodados.ibge.gov.br/api/v1/censos/nomes/ranking")        
    .then(response => response.json())                              
    .then(data => {                                                 
        let divDados = document.getElementById('dados');            
        data.reverse().forEach(item => {                            
            let div = document.createElement('div');                
            div.classList.add('lista_nomes');                       
            div.textContent = `Nome: ${item.nome}, Rank: ${item.rank}`;         
            divDados.appendChild(div);                               
        });
    })
    .catch(error => console.error('Erro:', error));                  