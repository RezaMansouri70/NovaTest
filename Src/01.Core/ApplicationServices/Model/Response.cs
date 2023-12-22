﻿namespace ApplicationServices.Model
{
    public class Response<TData>
    {
        public Response()
        {
        }
        public Response(TData data)
        {
            Success = true;
            Data = data;
        }
        public Response(TData data, int pageIndex, int pageSize, int totalRecords)
        {
            Success = true;
            Data = data;
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalRecords = totalRecords;
        }
        public Response(int error)
        {
            Success = false;
            Error = error;
        }
        public Response(int error, string errorMessage)
        {
            Success = false;
            Error = error;
            ErrorMessage = errorMessage;

        }
        public bool Success { get; set; }
        public TData? Data { get; set; }
        public int Error { get; set; }
        public string ErrorMessage { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }
    }
}
