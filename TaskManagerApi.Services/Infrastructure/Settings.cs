namespace TaskManager.Services.Infrastructure
{

    public class Settings
    {
        public Authentication Authentication { get; set; } = null!;
        public JwtConfig JwtConfig { get; set; } = null!;
        public RedisConfig redisConfig { get; set; } = null!;
        public ZeroBounceConfig ZeroBounceConfig { get; set; } = null!;
        public EmailSenderOptions EmailSenderOptions { get; set; } = null!;
    }

    public class EmailSenderOptions
    {
        public string SmtpServer { get; set; }
        public int Port { get; set; }
        public bool UseSsl { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
    }

    public class ZeroBounceConfig
    {
        public string Url { get; set; }
        public string ApiKey { get; set; }
    }

    public class RedisConfig
    {
        public string InstanceId { get; set; } = null!;
        public string Host { get; set; } = null!;
        public string IP { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Port { get; set; }
    }


    public class JwtConfig
    {
        public string Secret { get; set; }
        public double Expires { get; set; }
        public string ImpersonationExpires { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }

    public class Authentication
    {
        public Google Google { get; set; }
    }

    public class Google
    {
        public string ClientSecret { get; set; }
        public string ClientId { get; set; }
    }
}
