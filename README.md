# 🚀 PedidosApi - Sistema de E-commerce

**Desafio Técnico ASP.NET Core Web API**  
Projeto focado em **domínio rico** e **padrões de design** para evolução de raciocínio lógico.

## 📌 Objetivo
Construir um sistema de pedidos com:
- **Encapsulamento** de regras de negócio
- **Design Patterns** aplicados intencionalmente
- Arquitetura limpa e testável

## 🔧 Stack
- ASP.NET Core 6 (Web API)
- Entity Framework Core (SQL Server)
- xUnit (Testes)
- Swagger (Documentação)

  ## 🎯 Funcionalidades (Fase 1)
1. **Cadastro de Produtos**
   - CRUD básico
   - Controle de estoque

2. **Processamento de Pedidos**
   - Adição de itens (Command Pattern)
   - Checkout com Strategy Pattern

3. **Notificações**
   - Observer Pattern para e-mail/SMS

## 💡 Design Patterns Aplicados
| Padrão | Onde? | Problema Resolvido |
|--------|-------|--------------------|
| **Command** | `AdicionarItemHandler` | Desacopla ações complexas |
| **Strategy** | `IPagamentoStrategy` | Novos métodos de pagamento sem modificar código |
| **Observer** | `IPedidoObserver` | Notificações flexíveis |
| **Repository** | `IProdutoRepository` | Abstação do acesso a dados |
