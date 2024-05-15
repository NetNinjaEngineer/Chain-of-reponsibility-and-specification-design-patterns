namespace Generic_chain_of_reponsibility
{
    internal class Response
    {
        public Response(bool approved, string? message, ApprovedBy approvedBy)
        {
            Approved = approved;
            Message = message;
            ApprovedBy = approvedBy;
        }

        public bool Approved { get; set; }

        public string? Message { get; set; }

        public ApprovedBy ApprovedBy { get; set; }

        public override string ToString()
        {
            return $"\n" +
                $"{ApprovedBy} {(Approved ? "approved" : "not approved")} your document\n" +
                $"{Message}\n" +
                $"==================================";
        }
    }

    internal enum ApprovedBy
    {
        Manager,
        Director,
        CEO
    }
}
