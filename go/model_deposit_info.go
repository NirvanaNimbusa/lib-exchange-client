/*
 * Blockchain.com Exchange REST API
 *
 * ## Introduction Welcome to Blockchain.com's Exchange API and developer documentation. \\ These documents detail and give examples of various functionality offered by the API such as receiving real time market data, requesting balance information and performing trades. ## To Get Started Create or log into your existing Blockchain.com Exchange account \\ Select API from the drop down menu \\ Fill out form and click “Create New API Key Now” \\ Once generated you can view your keys under API Settings. \\ Please be aware that the API key can only be used once it was verified via email.  The API key must be set via the \\ `X-API-Token`\\ header.  The base URL to be used for all calls is \\ `https://api.blockchain.com/v3/exchange`  Autogenerated clients for this API can be found [here](https://github.com/blockchain/lib-exchange-client). 
 *
 * API version: 1.0.0
 * Generated by: OpenAPI Generator (https://openapi-generator.tech)
 */

package openapi
// DepositInfo struct for DepositInfo
type DepositInfo struct {
	// Unique ID for this withdrawal
	DepositId string `json:"depositId"`
	// The amount that is credited in the currency specified
	Amount float64 `json:"amount"`
	Currency string `json:"currency"`
	// Address to deposit to. If a tag or memo must be used, it is separated by a colon.
	Address string `json:"address"`
	// The transaction hash of the transaction that deposited funds
	TxHash string `json:"txHash,omitempty"`
	State string `json:"state"`
	// Time in ms since 01/01/1970 (epoch)
	Timestamp int64 `json:"timestamp,omitempty"`
}
