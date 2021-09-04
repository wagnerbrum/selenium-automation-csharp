#language: pt-br
Funcionalidade: Inventory

Esquema do Cenário: Verificar valores dos produtos
    Dado que acesso o site
    Quando informo as seguintes credenciais
        | Username      | Password     |
        | standard_user | secret_sauce |
    E me autentico no sistema
    Então os valores dos produtos devem ser <NomeProduto> e <PrecoProduto>

    Exemplos:
        | NomeProduto                         | PrecoProduto |
        | 'Sauce Labs Backpack'               | '$29.99'     |
        | 'Sauce Labs Bike Light'             | '$9.99'      |
        | 'Sauce Labs Bolt T-Shirt'           | '$15.99'     |
        | 'Sauce Labs Fleece Jacket'          | '$49.99'     |
        | 'Sauce Labs Onesie'                 | '$7.99'      |
        | 'Test.allTheThings() T-Shirt (Red)' | '$15.99'     |
