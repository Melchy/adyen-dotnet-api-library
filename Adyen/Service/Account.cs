﻿using System.Threading.Tasks;
using Adyen.Model.MarketPay;
using Adyen.Service.Resource.Account;
using Newtonsoft.Json;

namespace Adyen.Service
{
    public class Account : AbstractService
    {
        private readonly CloseAccount _closeAccount;
        private readonly CloseAccountHolder _closeAccountHolder;
        private readonly CreateAccount _createAccount;
        private readonly CreateAccountHolder _createAccountHolder;
        private readonly CheckAccountHolder _checkAccountHolder;
        private readonly DeletePayoutMethods _deletePayoutMethods;
        private readonly DeleteBankAccount _deleteBankAccount;
        private readonly DeleteShareholder _deleteShareholder;
        private readonly GetAccountHolder _getAccountHolder;
        private readonly GetUploadedDocuments _getUploadedDocuments;
        private readonly SuspendAccountHolder _suspendAccountHolder;
        private readonly UnSuspendAccountHolder _unSuspendAccountHolder;
        private readonly UpdateAccount _updateAccount;
        private readonly UpdateAccountHolder _updateAccountHolder;
        private readonly UpdateAccountHolderState _updateAccountHolderState;
        private readonly UploadDocument _uploadDocument;

        public Account(Client client)
            : base(client)
        {
            _closeAccount = new CloseAccount(this);
            _closeAccountHolder = new CloseAccountHolder(this);
            _createAccount = new CreateAccount(this);
            _createAccountHolder = new CreateAccountHolder(this);
            _checkAccountHolder = new CheckAccountHolder(this);
            _deletePayoutMethods = new DeletePayoutMethods(this);
            _deleteBankAccount = new DeleteBankAccount(this);
            _deleteShareholder = new DeleteShareholder(this);
            _getAccountHolder = new GetAccountHolder(this);
            _getUploadedDocuments = new GetUploadedDocuments(this);
            _suspendAccountHolder = new SuspendAccountHolder(this);
            _unSuspendAccountHolder = new UnSuspendAccountHolder(this);
            _updateAccount = new UpdateAccount(this);
            _updateAccountHolder = new UpdateAccountHolder(this);
            _updateAccountHolderState = new UpdateAccountHolderState(this);
            _uploadDocument = new UploadDocument(this);
        }

        /// <summary>
        /// Post /closeAccount API call
        /// </summary>
        /// <param name="closeAccountRequest"></param>
        /// <returns>CloseAccountResponse</returns>
        public CloseAccountResponse CloseAccount(CloseAccountRequest closeAccountRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(closeAccountRequest);
            var jsonResponse = _closeAccount.Request(jsonRequest);
            return JsonConvert.DeserializeObject<CloseAccountResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /closeAccount API call async
        /// </summary>
        /// <param name="closeAccountRequest"></param>
        /// <returns>CloseAccountResponse</returns>
        public async Task<CloseAccountResponse> CloseAccountAsync(CloseAccountRequest closeAccountRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(closeAccountRequest);
            var jsonResponse = await _closeAccount.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<CloseAccountResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /closeAccountHolder API call
        /// </summary>
        /// <param name="closeAccountHolderRequest"></param>
        /// <returns>CloseAccountResponse</returns>
        public CloseAccountHolderResponse CloseAccountHolder(CloseAccountHolderRequest closeAccountHolderRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(closeAccountHolderRequest);
            var jsonResponse = _closeAccountHolder.Request(jsonRequest);
            return JsonConvert.DeserializeObject<CloseAccountHolderResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /closeAccountHolder API call async
        /// </summary>
        /// <param name="closeAccountHolderRequest"></param>
        /// <returns>CloseAccountResponse</returns>
        public async Task<CloseAccountHolderResponse> CloseAccountHolderAsync(CloseAccountHolderRequest closeAccountHolderRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(closeAccountHolderRequest);
            var jsonResponse = await _closeAccountHolder.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<CloseAccountHolderResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /createAccount API call
        /// </summary>
        /// <param name="createAccountRequest"></param>
        /// <returns>CloseAccountResponse</returns>
        public CreateAccountResponse CreateAccount(CreateAccountRequest createAccountRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(createAccountRequest);
            var jsonResponse = _createAccount.Request(jsonRequest);
            return JsonConvert.DeserializeObject<CreateAccountResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /createAccount API call async
        /// </summary>
        /// <param name="createAccountRequest"></param>
        /// <returns>CloseAccountResponse</returns>
        public async Task<CreateAccountResponse> CreateAccountAsync(CreateAccountRequest createAccountRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(createAccountRequest);
            var jsonResponse = await _createAccount.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<CreateAccountResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /createAccountHolder API call
        /// </summary>
        /// <param name="createAccountHolderRequest"></param>
        /// <returns>CloseAccountHolderResponse</returns>
        public CreateAccountHolderResponse CreateAccountHolder(CreateAccountHolderRequest createAccountHolderRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(createAccountHolderRequest);
            var jsonResponse = _createAccountHolder.Request(jsonRequest);
            return JsonConvert.DeserializeObject<CreateAccountHolderResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /createAccountHolder API call async
        /// </summary>
        /// <param name="createAccountHolderRequest"></param>
        /// <returns>CloseAccountHolderResponse</returns>
        public async Task<CreateAccountHolderResponse> CreateAccountHolderAsync(CreateAccountHolderRequest createAccountHolderRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(createAccountHolderRequest);
            var jsonResponse = await _createAccountHolder.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<CreateAccountHolderResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /deleteBankAccount API call
        /// </summary>
        /// <param name="deleteBankAccountRequest"></param>
        /// <returns>GenericResponse</returns>
        public GenericResponse DeleteBankAccount(DeleteBankAccountRequest deleteBankAccountRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(deleteBankAccountRequest);
            var jsonResponse = _deleteBankAccount.Request(jsonRequest);
            return JsonConvert.DeserializeObject<GenericResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /deleteBankAccount API call async
        /// </summary>
        /// <param name="deleteBankAccountRequest"></param>
        /// <returns>GenericResponse</returns>
        public async Task<GenericResponse> DeleteBankAccountAsync(DeleteBankAccountRequest deleteBankAccountRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(deleteBankAccountRequest);
            var jsonResponse = await _deleteBankAccount.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<GenericResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /deleteShareHolder API call
        /// </summary>
        /// <param name="deleteShareholderRequest"></param>
        /// <returns>GenericResponse</returns>
        public GenericResponse DeleteShareHolder(DeleteShareholderRequest deleteShareholderRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(deleteShareholderRequest);
            var jsonResponse = _deleteShareholder.Request(jsonRequest);
            return JsonConvert.DeserializeObject<GenericResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /deleteShareHolder API call async
        /// </summary>
        /// <param name="deleteShareholderRequest"></param>
        /// <returns>GenericResponse</returns>
        public async Task<GenericResponse> DeleteShareHolderAsync(DeleteShareholderRequest deleteShareholderRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(deleteShareholderRequest);
            var jsonResponse = await _deleteShareholder.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<GenericResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /getAccountHolder API call
        /// </summary>
        /// <param name="getAccountHolderRequest"></param>
        /// <returns>GetAccountHolderResponse</returns>
        public GetAccountHolderResponse GetAccountHolder(GetAccountHolderRequest getAccountHolderRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(getAccountHolderRequest);
            var jsonResponse = _getAccountHolder.Request(jsonRequest);
            return JsonConvert.DeserializeObject<GetAccountHolderResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /getAccountHolder API call async
        /// </summary>
        /// <param name="getAccountHolderRequest"></param>
        /// <returns>GetAccountHolderResponse</returns>
        public async Task<GetAccountHolderResponse> GetAccountHolderAsync(GetAccountHolderRequest getAccountHolderRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(getAccountHolderRequest);
            var jsonResponse = await _getAccountHolder.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<GetAccountHolderResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /getUploadedDocuments API call
        /// </summary>
        /// <param name="getUploadedDocumentsRequest"></param>
        /// <returns>GetUploadedDocumentsResponse</returns>
        public GetUploadedDocumentsResponse GetUploadedDocuments(GetUploadedDocumentsRequest getUploadedDocumentsRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(getUploadedDocumentsRequest);
            var jsonResponse = _getUploadedDocuments.Request(jsonRequest);
            return JsonConvert.DeserializeObject<GetUploadedDocumentsResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /getUploadedDocuments API call async
        /// </summary>
        /// <param name="getUploadedDocumentsRequest"></param>
        /// <returns>GetUploadedDocumentsResponse</returns>
        public async Task<GetUploadedDocumentsResponse> GetUploadedDocumentsAsync(GetUploadedDocumentsRequest getUploadedDocumentsRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(getUploadedDocumentsRequest);
            var jsonResponse = await _getUploadedDocuments.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<GetUploadedDocumentsResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /suspendAccountHolder API call
        /// </summary>
        /// <param name="suspendAccountHolderRequest"></param>
        /// <returns>SuspendAccountHolderResponse</returns>
        public SuspendAccountHolderResponse SuspendAccountHolder(SuspendAccountHolderRequest suspendAccountHolderRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(suspendAccountHolderRequest);
            var jsonResponse = _suspendAccountHolder.Request(jsonRequest);
            return JsonConvert.DeserializeObject<SuspendAccountHolderResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /suspendAccountHolder API call async
        /// </summary>
        /// <param name="suspendAccountHolderRequest"></param>
        /// <returns>SuspendAccountHolderResponse</returns>
        public async Task<SuspendAccountHolderResponse> SuspendAccountHolderAsync(SuspendAccountHolderRequest suspendAccountHolderRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(suspendAccountHolderRequest);
            var jsonResponse = await _suspendAccountHolder.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<SuspendAccountHolderResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /unSuspendAccountHolder API call
        /// </summary>
        /// <param name="unSuspendAccountHolderRequest"></param>
        /// <returns>UnSuspendAccountHolderResponse</returns>
        public UnSuspendAccountHolderResponse UnSuspendAccountHolder(UnSuspendAccountHolderRequest unSuspendAccountHolderRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(unSuspendAccountHolderRequest);
            var jsonResponse = _unSuspendAccountHolder.Request(jsonRequest);
            return JsonConvert.DeserializeObject<UnSuspendAccountHolderResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /unSuspendAccountHolder API call async
        /// </summary>
        /// <param name="unSuspendAccountHolderRequest"></param>
        /// <returns>UnSuspendAccountHolderResponse</returns>
        public async Task<UnSuspendAccountHolderResponse> UnSuspendAccountHolderAsync(UnSuspendAccountHolderRequest unSuspendAccountHolderRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(unSuspendAccountHolderRequest);
            var jsonResponse = await _unSuspendAccountHolder.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<UnSuspendAccountHolderResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /updateAccount API call
        /// </summary>
        /// <param name="updateAccountRequest"></param>
        /// <returns>UpdateAccountResponse</returns>
        public UpdateAccountResponse UpdateAccount(UpdateAccountRequest updateAccountRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(updateAccountRequest);
            var jsonResponse = _updateAccount.Request(jsonRequest);
            return JsonConvert.DeserializeObject<UpdateAccountResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /updateAccount API call async
        /// </summary>
        /// <param name="updateAccountRequest"></param>
        /// <returns>UpdateAccountResponse</returns>
        public async Task<UpdateAccountResponse> UpdateAccountAsync(UpdateAccountRequest updateAccountRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(updateAccountRequest);
            var jsonResponse = await _updateAccount.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<UpdateAccountResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /updateAccountHolder API call
        /// </summary>
        /// <param name="updateAccountHolderRequest"></param>
        /// <returns>UpdateAccountHolderResponse</returns>
        public UpdateAccountHolderResponse UpdateAccountHolder(UpdateAccountHolderRequest updateAccountHolderRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(updateAccountHolderRequest);
            var jsonResponse = _updateAccountHolder.Request(jsonRequest);
            return JsonConvert.DeserializeObject<UpdateAccountHolderResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /updateAccountHolder API call async
        /// </summary>
        /// <param name="updateAccountHolderRequest"></param>
        /// <returns>UpdateAccountHolderResponse</returns>
        public async Task<UpdateAccountHolderResponse> UpdateAccountHolderAsync(UpdateAccountHolderRequest updateAccountHolderRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(updateAccountHolderRequest);
            var jsonResponse = await _updateAccountHolder.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<UpdateAccountHolderResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /updateAccountHolderState API call
        /// </summary>
        /// <param name="updateAccountHolderStateRequest"></param>
        /// <returns>GetAccountHolderStatusResponse</returns>
        public GetAccountHolderStatusResponse UpdateAccountHolderState(UpdateAccountHolderStateRequest updateAccountHolderStateRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(updateAccountHolderStateRequest);
            var jsonResponse = _updateAccountHolderState.Request(jsonRequest);
            return JsonConvert.DeserializeObject<GetAccountHolderStatusResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /updateAccountHolderState API call async
        /// </summary>
        /// <param name="updateAccountHolderStateRequest"></param>
        /// <returns>GetAccountHolderStatusResponse</returns>
        public async Task<GetAccountHolderStatusResponse> UpdateAccountHolderStateAsync(UpdateAccountHolderStateRequest updateAccountHolderStateRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(updateAccountHolderStateRequest);
            var jsonResponse = await _updateAccountHolderState.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<GetAccountHolderStatusResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /uploadDocument API call
        /// </summary>
        /// <param name="uploadDocumentRequest"></param>
        /// <returns> UploadDocumentResponse </returns>
        public UploadDocumentResponse UploadDocument(UploadDocumentRequest uploadDocumentRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(uploadDocumentRequest);
            var jsonResponse = _uploadDocument.Request(jsonRequest);
            return JsonConvert.DeserializeObject<UploadDocumentResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /uploadDocument API call async
        /// </summary>
        /// <param name="uploadDocumentRequest"></param>
        /// <returns> UploadDocumentResponse </returns>
        public async Task<UploadDocumentResponse> UploadDocumentAsync(UploadDocumentRequest uploadDocumentRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(uploadDocumentRequest);
            var jsonResponse = await _uploadDocument.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<UploadDocumentResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /checkAccountholder API call
        /// </summary>
        /// <param name="performVerificationRequest"></param>
        /// <returns>GenericResponse</returns>
        public GenericResponse CheckAccountholder(PerformVerificationRequest performVerificationRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(performVerificationRequest);
            var jsonResponse = _checkAccountHolder.Request(jsonRequest);
            return JsonConvert.DeserializeObject<GenericResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /checkAccountholder API call async
        /// </summary>
        /// <param name="performVerificationRequest"></param>
        /// <returns>GenericResponse</returns>
        public async Task<GenericResponse> CheckAccountholderAsync(PerformVerificationRequest performVerificationRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(performVerificationRequest);
            var jsonResponse = await _checkAccountHolder.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<GenericResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /deletePayoutMethods API call
        /// </summary>
        /// <param name="deletePayoutMethodRequest"></param>
        /// <returns>GenericResponse</returns>
        public GenericResponse DeletePayoutMethods(DeletePayoutMethodRequest deletePayoutMethodRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(deletePayoutMethodRequest);
            var jsonResponse = _deletePayoutMethods.Request(jsonRequest);
            return JsonConvert.DeserializeObject<GenericResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /deletePayoutMethods API call async
        /// </summary>
        /// <param name="deletePayoutMethodRequest"></param>
        /// <returns>GenericResponse</returns>
        public async Task<GenericResponse> DeletePayoutMethodsAsync(DeletePayoutMethodRequest deletePayoutMethodRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(deletePayoutMethodRequest);
            var jsonResponse = await _deletePayoutMethods.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<GenericResponse>(jsonResponse);
        }
    }
}
