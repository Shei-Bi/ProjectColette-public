namespace Supercell.Laser.Logic.Message.Account.Auth
{
    public class AuthenticationOkMessage : GameMessage
    {
        public long AccountId;
        public string PassToken;
        public string ServerEnvironment;

        public AuthenticationOkMessage() : base()
        {
            ;
        }

        public override void Encode()
        {
            Stream.WriteLong(AccountId);
            Stream.WriteLong(AccountId);

            Stream.WriteString(PassToken);
            Stream.WriteString(null);
            Stream.WriteString(null);

            Stream.WriteInt(36);
            Stream.WriteInt(218);
            Stream.WriteInt(1);

            Stream.WriteString("prod");

            Stream.WriteInt(0);
            Stream.WriteInt(0);
            Stream.WriteInt(0);

            Stream.WriteString(null);
            Stream.WriteString(null);
            Stream.WriteString(null);

            Stream.WriteInt(0);

            Stream.WriteString(null);
            Stream.WriteString("RU");
            Stream.WriteString(null);

            Stream.WriteInt(0);
            Stream.WriteString(null);

            Stream.WriteInt(2);
            Stream.WriteString("https://game-assets.brawlstarsgame.com");
            Stream.WriteString("http://a678dbc1c015a893c9fd-4e8cc3b1ad3a3c940c504815caefa967.r87.cf2.rackcdn.com");

            Stream.WriteInt(2);
            Stream.WriteString("https://event-assets.brawlstars.com");
            Stream.WriteString("https://24b999e6da07674e22b0-8209975788a0f2469e68e84405ae4fcf.ssl.cf2.rackcdn.com/event-assets");

            Stream.WriteVInt(0);
            Stream.WriteCompressedString("");
            Stream.WriteBoolean(true);
            Stream.WriteBoolean(false);
            Stream.WriteString("");
            Stream.WriteString("");
            Stream.WriteString("");
            Stream.WriteString("https://play.google.com/store/apps/details?id=com.supercell.brawlstars");
            Stream.WriteString("");
            Stream.WriteBoolean(false);

            Stream.WriteBoolean(false);
            Stream.WriteBoolean(false);
            Stream.WriteBoolean(false);
            Stream.WriteBoolean(false);
        }

        public override int GetMessageType()
        {
            return 20104;
        }

        public override int GetServiceNodeType()
        {
            return 1;
        }
    }
}
