📊 Fintech Blazor

Interface web do ecossistema Fintech, desenvolvida em Blazor WebAssembly, consumindo a API principal do projeto Fintech e integrando dados financeiros externos em tempo real para exibição de gráficos.

🚀 Tecnologias
.NET 10
Blazor WebAssembly
C#
Integração com APIs externas de cotação de moedas e criptomoedas
🔗 Integrações

Além de consumir a API principal do Fintech, o projeto se conecta a duas APIs externas para alimentar os gráficos e indicadores financeiros:

💱 API de cotação de moedas — exibição de taxas de câmbio
🪙 API de criptomoedas — exibição de cotações em tempo real de criptoativos
🏗️ Sobre o projeto

Este repositório contém exclusivamente a camada web (Blazor) do ecossistema Fintech. A API e o aplicativo mobile (.NET MAUI) estão no repositório principal: Fintech.

Rodando inteiramente no navegador via WebAssembly, a aplicação consome a API do Fintech para as operações financeiras do usuário e enriquece a experiência com dados de mercado em tempo real, exibidos em gráficos.

▶️ Como rodar o projeto
bash
# Clone o repositório
git clone https://github.com/welinton19/Fintech-Blazor.git

# Acesse a pasta do projeto
cd Fintech-Blazor

# Restaure as dependências
dotnet restore

# Execute a aplicação
dotnet run

⚠️ É necessário que a API do Fintech esteja em execução para o funcionamento completo das funcionalidades.

📌 Observações

Este projeto faz parte de um ecossistema maior. Confira também:

Fintech — API principal e app mobile (.NET MAUI)

Desenvolvido por Welinton Gomes
