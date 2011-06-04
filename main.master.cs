using System;
using System.IO.Compression;

public partial class main : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Request.Headers["Accept-encoding"] != null && Request.Headers["Accept-encoding"].Contains("gzip"))
        //{
        //    Response.Filter = new GZipStream(Response.Filter, CompressionMode.Compress, true);
        //    Response.AppendHeader("Content-encoding", "gzip");
        //}
        //else if (Request.Headers["Accept-encoding"] != null && Request.Headers["Accept-encoding"].Contains("deflate"))
        //{
        //    Response.Filter = new DeflateStream(Response.Filter, CompressionMode.Compress, true);
        //    Response.AppendHeader("Content-encoding", "deflate");
        //}
    }
}
