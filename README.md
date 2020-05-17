# dotnet-cardano-rest-api-blockchain-explorer
C# .NET Cardano REST API Blockchain Explorer

<b>IMPORTANT</b>

You should run the cardano-rest api in order to use this library.

cardano-rest: https://github.com/input-output-hk/cardano-rest

cardano-rest wiki documentation using docker: https://github.com/input-output-hk/cardano-rest/wiki/Docker 

All requests information is here: https://input-output-hk.github.io/cardano-rest/explorer-api/

Usage:

<b>1. Initialize</b>

<code>
  var explorerContext = new CardanoExplorerContext();
</code>
<br><br>

'CardanoExplorerContext' has a paramether 'cardanoNodeUrl' which has a default value. It can be changed if needed.

<b>2. Call desired request type.</b>

Request types:

2.1 AddressesRequests<br>
2.2 BlocksRequests<br>
2.3 EpochsRequests<br>
2.4 GenesisRequests<br>
2.5 HttpBridgeRequests<br>
2.6 TransactionsRequests<br>

Example:

<code>
  var transactionsRequests = explorerContext.TransactionsRequests;
</code>
<br><br>

<b>3. Call desired request.</b>

Example:

<code>
  var transactions = await transactionsRequests.GetTransactionsAsync();
</code>
<br><br>
