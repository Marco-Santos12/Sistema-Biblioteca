div align="center">

**SENAI · Técnico em Desenvolvimento de Sistemas**

# Projeto – BIBLIOTECA ESCOLAR

Luziânia · 2026

</div>

| | |
|---|---|
| **Componente Curricular** | Desenvolvimento de Projetos |
| **Professora** | Érika Alves Sardinha |
| **Alunos** | Bruno Felype Maciel de Brito, Davi de Araujo Silva, Marco Antônio Mendes dos Santos e Pedro Xavier Simões |
| **Série** | 2º Ano Técnico |
| **Data** | 21 de setembro de 2026 |

---

# Sistema de Gerenciamento de Biblioteca Escolar

Software de gestão bibliotecária que substitui o controle manual em fichas de papel e cadernos por um ambiente digital centralizado, automatizando o cadastro de obras e leitores, os empréstimos e devoluções, o controle de prazos e as reservas.

**Status:** em desenvolvimento (primeira entrega: planejamento e diagnóstico da solução).

## O problema

A biblioteca da instituição controla empréstimos e devoluções de forma totalmente manual. Isso causa:

- Perda frequente de exemplares do acervo;
- Dificuldade em saber quais obras estão com a devolução atrasada e quem são os usuários em débito;
- Registros com rasuras e extravios;
- Verificação de disponibilidade imprecisa, com busca feita presencialmente nas prateleiras;
- Filas constantes no atendimento;
- Ausência de relatórios de atrasos em tempo real.

## A solução

Um sistema que centraliza toda a operação da biblioteca, com atualização de saldo de exemplares em tempo real, cálculo automático de prazos, alertas de atraso, fila de reservas e indicadores para a gestão.

## Perfis de usuário

| Perfil | O que pode fazer |
|---|---|
| **Bibliotecários e Gestores** | Administrar o acervo (incluir, alterar e remover livros), cadastrar leitores, registrar empréstimos e devoluções e emitir relatórios. |
| **Leitores (alunos e professores)** | Consultar o catálogo digital, checar a disponibilidade de exemplares, acompanhar seus empréstimos ativos e reservar livros que estejam emprestados. |

## Funcionalidades

- **Catálogo geral e gestão do acervo (CRUD de livros):** cadastro, atualização, consulta com filtros e remoção de obras, com a disponibilidade dos exemplares atualizada instantaneamente.
- **Gestão de usuários e perfis:** registro de alunos e professores, controle de permissões de acesso e histórico de utilização de cada leitor.
- **Empréstimos e devoluções:** registro rápido e seguro da saída e do retorno das obras, vinculando o livro ao leitor.
- **Controle de prazos e inadimplência:** monitoramento dos dias de posse, cálculo de datas de entrega, alertas de itens vencidos e bloqueio temporário de novos empréstimos para usuários com pendências.
- **Fila de espera (reservas):** leitores podem reservar títulos emprestados, com prioridade de retirada assim que a obra for devolvida.
- **Relatórios gerenciais:** estatísticas do acervo, obras mais procuradas, índice de devoluções no prazo e lista detalhada de devedores, com tabelas e gráficos exportáveis.
- **Autenticação segura:** acesso por e-mail/matrícula e senha, com permissões separadas por perfil.

## Dados do sistema

- **Leitor:** nome completo, matrícula/CPF, e-mail, vínculo (aluno ou professor), turma/curso e situação do cadastro (ativo ou suspenso).
- **Acervo:** título, autor, editora, ISBN, ano de publicação, categoria/gênero, edição, estado de conservação, quantidade total e saldo disponível.
- **Movimentação (empréstimo):** identificador da transação, leitor, livro, data de retirada, data limite de devolução, data de entrega efetiva e status (em andamento, devolvido ou em atraso).

## Telas e fluxo de acesso

- **Login:** entrada simplificada por e-mail/matrícula e senha.
- **Dashboard:** atalhos rápidos (Novo Empréstimo / Devolução) e painel de alertas com devoluções do dia e itens em atraso.
- **Módulo de Acervo:** tabela dinâmica com busca avançada, inclusão e edição de livros.
- **Módulo de Leitores:** cadastro e listagem de alunos e professores.
- **Módulo de Movimentações:** registro rápido de saídas, devoluções e reservas.
- **Módulo de Relatórios:** painel gerencial com gráficos e tabelas exportáveis.

Após o login, o sistema direciona o usuário conforme o perfil: o **bibliotecário** vai direto ao Dashboard administrativo, e o **leitor** abre a consulta ao catálogo, com a lista dos livros em sua posse e os respectivos prazos.

---

**SENAI** · Serviço Nacional de Aprendizagem Industrial
