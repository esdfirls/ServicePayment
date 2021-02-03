# ServicePayment

Processamento de contratos automatizado. O processamento de
um contrato consiste em gerar as parcelas a serem pagas para aquele contrato, com base no
número de meses desejado.
A empresa utiliza um serviço de pagamento online para realizar o pagamento das parcelas.
Os serviços de pagamento online tipicamente cobram um juro mensal, bem como uma taxa
por pagamento. Por enquanto, o serviço contratado pela empresa é o do Paypal, que aplica
juros simples de 1% a cada parcela, mais uma taxa de pagamento de 2%.
O programa lê os dados de um contrato (número do contrato, data do contrato,
e valor total do contrato). Em seguida, o programa lê o número de meses para
parcelamento do contrato, então gera os registros de parcelas a serem pagas (data e valor),
sendo a primeira parcela a ser paga um mês após a data do contrato, a segunda parcela dois
meses após o contrato e assim por diante. Dados das parcelas estão apresentados na tela.

Ex

![image](https://i.ibb.co/S7smKz5/image.png)

![image2](https://i.ibb.co/KVX5ZPp/image.png)

![image3](https://i.ibb.co/wrY6ShM/image.png)
