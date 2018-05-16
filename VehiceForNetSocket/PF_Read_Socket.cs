using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gfVehicleLibraryPF;
using ConvertInfo;
using VehicleNetBase;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace VehicleForNetSocket
{
    public class PF_Read_Socket: PF_IRead
    {
        private Socket socket { get; set; }

        public Vehicle_DR001_Login_Response Read_Verify(Vehicle_DR001_Login_Request Req)
        {
            //ModelToXML
            PF_ModelToXML modelToXml = new PF_ModelToXML();
            string strWriteXmlDoc = modelToXml.ModelToXml("Verify", Req);

            string strIPAddress = SocketHelper.Address;
            int Port = SocketHelper.Port;

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(strIPAddress, Port);

            if (socket.Connected == true)
            {
                socket.Send(Encoding.ASCII.GetBytes(strWriteXmlDoc));
            }

            byte[] res = new byte[2056];

            Func<Socket, byte[], string> func = (socketClient, data) =>
            {
                string strRevData = "";
                int receiveLength = socketClient.Receive(data, data.Length, SocketFlags.None);
                if (receiveLength > 0)
                {
                    strRevData = Encoding.ASCII.GetString(data, 0, receiveLength);
                }

                return strRevData;
            };

            IAsyncResult ar = func.BeginInvoke(socket, res, null, null);

            while (ar.IsCompleted)
            {
                break;
            }

            string strResult = func.EndInvoke(ar);
            socket.Close();

            Vehicle_DR001_Login_Response m_Vehicle_DR001_Login_Response = new Vehicle_DR001_Login_Response();
            PF_XMLToModel xmlToModel = new PF_XMLToModel();
            m_Vehicle_DR001_Login_Response.Name = "Verify";
            m_Vehicle_DR001_Login_Response = (Vehicle_DR001_Login_Response)xmlToModel.Resp_XmlToModel(m_Vehicle_DR001_Login_Response, strResult);

            return m_Vehicle_DR001_Login_Response;
        }

        public Vehicle_DR004_GetTime_Response Read_GetTime(Vehicle_DR004_GetTime_Request Req)
        {
            PF_ModelToXML modelToXml = new PF_ModelToXML();
            string strWriteXmlDoc = modelToXml.ModelToXml("GetTime", Req);

            string strIPAddress = SocketHelper.Address;
            int Port = SocketHelper.Port;

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(strIPAddress, Port);

            if (socket.Connected == true)
            {
                socket.Send(Encoding.ASCII.GetBytes(strWriteXmlDoc));
            }

            byte[] res = new byte[2056];

            Func<Socket, byte[], string> func = (socketClient, data) =>
            {
                string strRevData = "";
                int receiveLength = socketClient.Receive(data, data.Length, SocketFlags.None);
                if (receiveLength > 0)
                {
                    strRevData = Encoding.ASCII.GetString(data, 0, receiveLength);
                }

                return strRevData;
            };

            IAsyncResult ar = func.BeginInvoke(socket, res, null, null);

            while (ar.IsCompleted)
            {
                break;
            }

            string strResult = func.EndInvoke(ar);
            socket.Close();

            Vehicle_DR004_GetTime_Response m_Vehicle_DR004_GetTime_Response = new Vehicle_DR004_GetTime_Response();
            PF_XMLToModel xmlToModel = new PF_XMLToModel();
            m_Vehicle_DR004_GetTime_Response.Name = "GetTime";
            m_Vehicle_DR004_GetTime_Response = (Vehicle_DR004_GetTime_Response)xmlToModel.Resp_XmlToModel(m_Vehicle_DR004_GetTime_Response, strResult);

            return m_Vehicle_DR004_GetTime_Response;



        }
    }
}
