/*
 * Blockchain.com Exchange REST API
 *
 * ## Introduction Welcome to Blockchain.com's Exchange API and developer documentation. \\ These documents detail and give examples of various functionality offered by the API such as receiving real time market data, requesting balance information and performing trades. ## To Get Started Create or log into your existing Blockchain.com Exchange account \\ Select API from the drop down menu \\ Fill out form and click “Create New API Key Now” \\ Once generated you can view your keys under API Settings. \\ Please be aware that the API key can only be used once it was verified via email.  The API key must be set via the \\ `X-API-Token`\\ header.  The base URL to be used for all calls is \\ `https://api.blockchain.com/v3/exchange`  Autogenerated clients for this API can be found [here](https://github.com/blockchain/lib-exchange-client). 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct DepositInfo {
    /// Unique ID for this withdrawal
    #[serde(rename = "depositId")]
    pub deposit_id: String,
    /// The amount that is credited in the currency specified
    #[serde(rename = "amount")]
    pub amount: f64,
    #[serde(rename = "currency")]
    pub currency: String,
    /// Address to deposit to. If a tag or memo must be used, it is separated by a colon.
    #[serde(rename = "address")]
    pub address: String,
    /// The transaction hash of the transaction that deposited funds
    #[serde(rename = "txHash", skip_serializing_if = "Option::is_none")]
    pub tx_hash: Option<String>,
    #[serde(rename = "state")]
    pub state: State,
    /// Time in ms since 01/01/1970 (epoch)
    #[serde(rename = "timestamp", skip_serializing_if = "Option::is_none")]
    pub timestamp: Option<i64>,
}

impl DepositInfo {
    pub fn new(deposit_id: String, amount: f64, currency: String, address: String, state: State) -> DepositInfo {
        DepositInfo {
            deposit_id,
            amount,
            currency,
            address,
            tx_hash: None,
            state,
            timestamp: None,
        }
    }
}

/// 
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum State {
    #[serde(rename = "REJECTED")]
    REJECTED,
    #[serde(rename = "UNCONFIRMED")]
    UNCONFIRMED,
    #[serde(rename = "COMPLETED")]
    COMPLETED,
}

