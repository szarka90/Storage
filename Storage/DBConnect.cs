using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;

namespace Storage
{
    static class DBConnect
    {
        public static void ConnectDataWriting(DatabaseConnect connect)
        {
            string filename = "connect.csv";
            StreamWriter writer = new StreamWriter(filename);
            writer.WriteLine($"{connect.Server};{connect.User};{connect.Port};{connect.Password};{connect.Database}");
            writer.Flush();
            writer.Close();
        }
        public static DatabaseConnect ConnectDataReading()
        {
            string filename = "connect.csv";
            DatabaseConnect connect;
            StreamReader reader = new StreamReader(filename);
            var values = reader.ReadLine().Split(';');
            connect = new DatabaseConnect((string)values[0], (string)values[1], Convert.ToUInt32(values[2]), (string)values[3], (string)values[4]);
            reader.Close();
            return connect;
        }
        #region DBConnection
        static MySqlConnection connection = DBConnect.InitDB();

        const MySqlSslMode sslMode = MySqlSslMode.None;

        public static MySqlConnection InitDB()
        {
            DatabaseConnect database;
            database = ConnectDataReading();

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = database.Server;
            builder.UserID = database.User;
            builder.Port = database.Port;
            builder.Password = database.Password;
            builder.Database = database.Database;
            builder.SslMode = sslMode;

            string connectionString = builder.ToString();

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                return connection;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hiba az adatbázis csatlakozás közben: " + ex.Message);

            }
            return default;
        }
        #endregion
        #region DBPartners
        public static List<PartnerClass> ListedPartners()
        {
            try
            {
                connection.Open();
                string querry = "SELECT * FROM partner;";
                MySqlCommand command = new MySqlCommand(querry, connection);

                List<PartnerClass> partners = new List<PartnerClass>();

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    partners.Add(new PartnerClass((int)reader["id"], (TypeOfPartner)Enum.Parse(typeof(TypeOfPartner), reader["type"].ToString(), true), (string)reader["name"], (string)reader["tax_number"], (string)reader["billing_country"], (string)reader["billing_postcode"], (string)reader["billing_city"], (string)reader["billing_address"], (string)reader["delivery_country"], (string)reader["delivery_postcode"], (string)reader["delivery_city"], (string)reader["delivery_address"], (string)reader["web"], (string)reader["bank_account"], (string)reader["comment"]));
                }
                reader.Close();
                connection.Close();
                return partners;
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen listázás", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void AddNewPartner(PartnerClass partner)
        {
            try
            {
                connection.Open();
                string querry = "INSERT INTO partner(type, name, tax_number, billing_country, billing_postcode, billing_city, billing_address, delivery_country, delivery_postcode, delivery_city, delivery_address, web, bank_account, comment) VALUES (@type, @name, @tax_number, @billing_country, @billing_postcode, @billing_city, @billing_address, @delivery_country, @delivery_postcode, @delivery_city, @delivery_address, @web, @bank_account, @comment);";
                MySqlCommand command = new MySqlCommand(querry, connection);

                command.Parameters.AddWithValue("@type", partner.Type);
                command.Parameters.AddWithValue("@name", partner.Name);
                command.Parameters.AddWithValue("@tax_number", partner.TaxNumber);
                command.Parameters.AddWithValue("@billing_country", partner.BillingCountry);
                command.Parameters.AddWithValue("@billing_postcode", partner.BillingPostcode);
                command.Parameters.AddWithValue("@billing_city", partner.BillingCity);
                command.Parameters.AddWithValue("@billing_address", partner.BillingAddress);
                command.Parameters.AddWithValue("@delivery_country", partner.DeliveryCountry);
                command.Parameters.AddWithValue("@delivery_postcode", partner.DeliveryPostcode);
                command.Parameters.AddWithValue("@delivery_city", partner.DeiveryCity);
                command.Parameters.AddWithValue("@delivery_address", partner.DeliveryAddress);
                command.Parameters.AddWithValue("@web", partner.Web);
                command.Parameters.AddWithValue("@bank_account", partner.BankAccount);
                command.Parameters.AddWithValue("@comment", partner.Comment);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Sikertelen feltöltés", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void ModificatePartner(PartnerClass partner)
        {
            try
            {
                connection.Open();

                string querry = "UPDATE partner SET type = @type, name = @name, tax_number = @tax_number, billing_country = @billing_country, billing_postcode = @billing_postcode, billing_city = @billing_city, billing_address = @billing_address, delivery_country = @delivery_country, delivery_postcode = @delivery_postcode, delivery_city = @delivery_city, delivery_address = @delivery_address, web = @web, bank_account = @bank_account, comment = @comment Where id = @id;";
                MySqlCommand command = new MySqlCommand(querry, connection);
                command.Parameters.AddWithValue("@type", partner.Type);
                command.Parameters.AddWithValue("@name", partner.Name);
                command.Parameters.AddWithValue("@tax_number", partner.TaxNumber);
                command.Parameters.AddWithValue("@billing_country", partner.BillingCountry);
                command.Parameters.AddWithValue("@billing_postcode", partner.BillingPostcode);
                command.Parameters.AddWithValue("@billing_city", partner.BillingCity);
                command.Parameters.AddWithValue("@billing_address", partner.BillingAddress);
                command.Parameters.AddWithValue("@delivery_country", partner.DeliveryCountry);
                command.Parameters.AddWithValue("@delivery_postcode", partner.DeliveryPostcode);
                command.Parameters.AddWithValue("@delivery_city", partner.DeiveryCity);
                command.Parameters.AddWithValue("@delivery_address", partner.DeliveryAddress);
                command.Parameters.AddWithValue("@web", partner.Web);
                command.Parameters.AddWithValue("@bank_account", partner.BankAccount);
                command.Parameters.AddWithValue("@comment", partner.Comment);
                command.Parameters.AddWithValue("@id", partner.Id);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen módosítás!", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void DeletePartner(PartnerClass partner)
        {
            try
            {
                connection.Open();
                string querry1 = "DELETE FROM partner WHERE id = @id;";
                string querry2 = "DELETE FROM contact_for_partners WHERE partner_id = @id;";
                
                MySqlCommand command1 = new MySqlCommand(querry1, connection);
                MySqlCommand command2 = new MySqlCommand(querry2, connection);
                command1.Parameters.AddWithValue("@id", partner.Id);
                command1.ExecuteNonQuery();
                command2.Parameters.AddWithValue("@id", partner.Id);
                command2.ExecuteNonQuery();
               
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Sikertelen törlés!", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static List<PartnerClass> SearchPartner(string kereses)
        {
            try
            {
                connection.Open();
                string querry = $"SELECT * FROM `partner` WHERE name LIKE '%{kereses}%';";
                MySqlCommand command = new MySqlCommand(querry, connection);
                List<PartnerClass> partners = new List<PartnerClass>();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    partners.Add(new PartnerClass((int)reader["id"], (TypeOfPartner)Enum.Parse(typeof(TypeOfPartner), reader["type"].ToString(), true), (string)reader["name"], (string)reader["tax_number"], (string)reader["billing_country"], (string)reader["billing_postcode"], (string)reader["billing_city"], (string)reader["billing_address"], (string)reader["delivery_country"], (string)reader["delivery_postcode"], (string)reader["delivery_city"], (string)reader["delivery_address"], (string)reader["web"], (string)reader["bank_account"], (string)reader["comment"]));
                }
                reader.Close();
                connection.Close();
                return partners;
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen listázás", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion
        #region CompanyData
        public static List<PartnerClass> CompanyDataReading()
        {
            try
            {
                connection.Open();
                string querry = "SELECT * FROM company_data;";
                MySqlCommand command = new MySqlCommand(querry, connection);

                List<PartnerClass> partners = new List<PartnerClass>();


                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    partners.Add(new PartnerClass((int)reader["id"], (string)reader["name"], (string)reader["tax_number"], (string)reader["country"], (string)reader["postcode"], (string)reader["city"], (string)reader["address"], (string)reader["web"], (string)reader["bank_account"], (string)reader["comment"]));
                }
                reader.Close();
                connection.Close();
                return partners;
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen listázás", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void CompanyDataAdd(PartnerClass partner)
        {
            try
            {
                connection.Open();
                string querry = "INSERT INTO company_data(name, tax_number, country, postcode, city, address, web, bank_account, comment) VALUES (@name, @tax_number, @country, @postcode, @city, @address, @web, @bank_account, @comment);";
                MySqlCommand command = new MySqlCommand(querry, connection);

                command.Parameters.AddWithValue("@name", partner.Name);
                command.Parameters.AddWithValue("@tax_number", partner.TaxNumber);
                command.Parameters.AddWithValue("@country", partner.BillingCountry);
                command.Parameters.AddWithValue("@postcode", partner.BillingPostcode);
                command.Parameters.AddWithValue("@city", partner.BillingCity);
                command.Parameters.AddWithValue("@address", partner.BillingAddress);
                command.Parameters.AddWithValue("@web", partner.Web);
                command.Parameters.AddWithValue("@bank_account", partner.BankAccount);
                command.Parameters.AddWithValue("@comment", partner.Comment);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Sikertelen feltöltés", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void CompanyDataModify(PartnerClass partner)
        {
            try
            {
                connection.Open();

                string querry = "UPDATE company_data SET name = @name, tax_number = @tax_number, country = @country, postcode = @postcode, city = @city, address = @address, web = @web, bank_account = @bank_account, comment = @comment Where id = @id;";
                MySqlCommand command = new MySqlCommand(querry, connection);
                command.Parameters.AddWithValue("@name", partner.Name);
                command.Parameters.AddWithValue("@tax_number", partner.TaxNumber);
                command.Parameters.AddWithValue("@country", partner.BillingCountry);
                command.Parameters.AddWithValue("@postcode", partner.BillingPostcode);
                command.Parameters.AddWithValue("@city", partner.BillingCity);
                command.Parameters.AddWithValue("@address", partner.BillingAddress);
                command.Parameters.AddWithValue("@web", partner.Web);
                command.Parameters.AddWithValue("@bank_account", partner.BankAccount);
                command.Parameters.AddWithValue("@comment", partner.Comment);
                command.Parameters.AddWithValue("@id", partner.Id);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen módosítás!", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion
        #region DBContats
        public static List<Contact> ListedContacts(PartnerClass partner)
        {
            try
            {
                connection.Open();
                int id = (int)partner.Id;
                string querry = "SELECT * FROM contact_for_partners WHERE partner_id = @id;";
                MySqlCommand command = new MySqlCommand(querry, connection);
                command.Parameters.AddWithValue("@id", id);
                List<Contact> contacts = new List<Contact>();

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    contacts.Add(new Contact((int)reader["id"], (int)reader["partner_id"], (string)reader["contact_name"], (string)reader["phone"], (string)reader["email"], (string)reader["title"]));
                }
                reader.Close();
                connection.Close();
                return contacts;
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen listázás!", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void AddNewContact(Contact kapcsolattarto)
        {
            try
            {
                connection.Open();
                string querry = "INSERT INTO contact_for_partners(partner_id, contact_name, phone, email, title) VALUES (@partner_id, @contact_name, @phone, @email, @title);";
                MySqlCommand command = new MySqlCommand(querry, connection);

                command.Parameters.AddWithValue("@partner_id", kapcsolattarto.PartnerId);
                command.Parameters.AddWithValue("@contact_name", kapcsolattarto.Name);
                command.Parameters.AddWithValue("@phone", kapcsolattarto.PhoneNumber);
                command.Parameters.AddWithValue("@email", kapcsolattarto.Email);
                command.Parameters.AddWithValue("@title", kapcsolattarto.Title);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Sikertelen feltöltés", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void ModifyContact(Contact kapcsolattarto)
        {
            try
            {
                connection.Open();

                string querry = "UPDATE contact_for_partners SET contact_name = @contact_name, phone = @phone, email = @email, title = @title Where id = @id;";
                MySqlCommand command = new MySqlCommand(querry, connection);
                command.Parameters.AddWithValue("@contact_name", kapcsolattarto.Name);
                command.Parameters.AddWithValue("@phone", kapcsolattarto.PhoneNumber);
                command.Parameters.AddWithValue("@email", kapcsolattarto.Email);
                command.Parameters.AddWithValue("@title", kapcsolattarto.Title);
                command.Parameters.AddWithValue("@id", kapcsolattarto.Id);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen módosítás!", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion
        #region DBLogin
        public static List<Users> ListUsers()
        {
            try
            {
                connection.Open();
                string querry = "SELECT * FROM users;";
                MySqlCommand command = new MySqlCommand(querry, connection);

                List<Users> users = new List<Users>();

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new Users((int)reader["id"], (string)reader["name"], (string)reader["user_name"], BitConverter.ToString((byte[])reader["password"], 0, ((byte[])reader["password"]).Length), DateTime.Parse(reader["Registered"].ToString()), (TypeOfUsers)Enum.Parse(typeof(TypeOfUsers), reader["type_of_users"].ToString(), true), (string)reader["email"]));
                }
                reader.Close();
                connection.Close();
                return users;
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen listázás", ex);
            }
            finally
            {
                connection.Close();
            }
        }       
        public static Users Login(string userInsert, string passInsert)
        {
            try
            {
                connection.Open();
                string querry = $"SELECT * FROM `users` WHERE (user_name, Password) = (@name, @password);";
                MySqlCommand command = new MySqlCommand(querry, connection);
                command.Parameters.AddWithValue("@name", userInsert);
                command.Parameters.AddWithValue("@password", Encrypt.HashString(passInsert));
                MySqlDataReader reader = command.ExecuteReader();               

                if (reader.Read())
                {
                    Users user = new Users((int)reader["id"], (string)reader["name"], (string)reader["user_name"], BitConverter.ToString((byte[])reader["password"], 0, ((byte[])reader["password"]).Length), DateTime.Parse(reader["Registered"].ToString()), (TypeOfUsers)Enum.Parse(typeof(TypeOfUsers), reader["type_of_users"].ToString(), true), (string)reader["email"]);

                    return user;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Információ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            finally
            {
                connection.Close();
            }
        }
        public static void AddNewUser(Users user)
        {
            try
            {
                connection.Open();
                string querry = "INSERT INTO users(name, user_name, password, Registered, type_of_users, email) VALUES (@name, @user_name, @password, @Registered, @type_of_users, @email);";
                MySqlCommand command = new MySqlCommand(querry, connection);

                command.Parameters.AddWithValue("@name", user.Name);
                command.Parameters.AddWithValue("@user_name", user.Username);
                command.Parameters.AddWithValue("@password", Encrypt.HashString(user.Password));
                command.Parameters.AddWithValue("@Registered", user.Registered);
                command.Parameters.AddWithValue("@type_of_users", user.TypeOfUsers);
                command.Parameters.AddWithValue("@email", user.Email);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Sikertelen feltöltés", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void ModifyUserAndPassword(Users user)
        {
            try
            {
                connection.Open();

                string querry = "UPDATE users SET name = @name, user_name = @user_name, password = @password, type_of_users = @type_of_users, email = @email Where id = @id;";
                MySqlCommand command = new MySqlCommand(querry, connection);
                command.Parameters.AddWithValue("@name", user.Name);
                command.Parameters.AddWithValue("@user_name", user.Username);
                command.Parameters.AddWithValue("@password", Encrypt.HashString(user.Password));
                command.Parameters.AddWithValue("@type_of_users", user.TypeOfUsers);
                command.Parameters.AddWithValue("@email", user.Email);
                command.Parameters.AddWithValue("@id", user.Id);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen módosítás!", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void ModifyUser(Users user)
        {
            try
            {
                connection.Open();

                string querry = "UPDATE users SET name = @name, user_name = @user_name, type_of_users = @type_of_users, email = @email Where id = @id;";
                MySqlCommand command = new MySqlCommand(querry, connection);
                command.Parameters.AddWithValue("@name", user.Name);
                command.Parameters.AddWithValue("@user_name", user.Username);
                command.Parameters.AddWithValue("@type_of_users", user.TypeOfUsers);
                command.Parameters.AddWithValue("@email", user.Email);
                command.Parameters.AddWithValue("@id", user.Id);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen módosítás!", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void DeleteUser(Users user)
        {
            try
            {
                connection.Open();
                string querry1 = "DELETE FROM users WHERE id = @id;";
                MySqlCommand command1 = new MySqlCommand(querry1, connection);
                command1.Parameters.AddWithValue("@id", user.Id);
                command1.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Sikertelen törlés!", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion
        #region DBProducts
        public static List<Products> ListProducts()
        {
            try
            {
                connection.Open();
                string querry = "SELECT * FROM products;";
                MySqlCommand command = new MySqlCommand(querry, connection);

                List<Products> products = new List<Products>();

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Products((int)reader["id"], (string)reader["product_name"], (string)reader["product_number"], (Quantity)Enum.Parse(typeof(Quantity), reader["quantity"].ToString(), true), (VAT)Enum.Parse(typeof(VAT), reader["vat"].ToString(), true), (double)reader["netto_buy_price"], (double)reader["brutto_buy_price"], (double)reader["netto_sell_price"], (double)reader["brutto_sell_price"], (int)reader["stock"], (int)reader["min_stock"]));
                }
                reader.Close();
                connection.Close();
                return products;
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen listázás", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void AddNewProduct(Products products)
        {
            try
            {
                connection.Open();
                string querry = "INSERT INTO products(product_name, product_number, quantity, vat, netto_buy_price, brutto_buy_price, netto_sell_price, brutto_sell_price, stock, min_stock) VALUES (@product_name, @product_number, @quantity, @vat, @netto_buy_price, @brutto_buy_price, @netto_sell_price, @brutto_sell_price, @stock, @min_stock);";
                MySqlCommand command = new MySqlCommand(querry, connection);

                command.Parameters.AddWithValue("@product_name", products.ProductName);
                command.Parameters.AddWithValue("@product_number", products.ProductNumber);
                command.Parameters.AddWithValue("@quantity", products.Quantity);
                command.Parameters.AddWithValue("@vat", products.Vat);
                command.Parameters.AddWithValue("@netto_buy_price", products.NettoBuyPrice);
                command.Parameters.AddWithValue("@brutto_buy_price", products.BruttoBuyPrice);
                command.Parameters.AddWithValue("@netto_sell_price", products.NettoSellPrice);
                command.Parameters.AddWithValue("@brutto_sell_price", products.BruttoSellPrice);
                command.Parameters.AddWithValue("@stock", products.Stock);
                command.Parameters.AddWithValue("@min_stock", products.MinStock);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Sikertelen feltöltés", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void ModifyProduct(Products products)
        {
            try
            {
                connection.Open();

                string querry = "UPDATE products SET product_name = @product_name, product_number = @product_number, quantity = @quantity, vat = @vat, netto_buy_price = @netto_buy_price, brutto_buy_price = @brutto_buy_price, netto_sell_price = @netto_sell_price, brutto_sell_price = @brutto_sell_price, stock = @stock, min_stock = @min_stock Where id = @id;";
                MySqlCommand command = new MySqlCommand(querry, connection);
                command.Parameters.AddWithValue("@product_name", products.ProductName);
                command.Parameters.AddWithValue("@product_number", products.ProductNumber);
                command.Parameters.AddWithValue("@quantity", products.Quantity);
                command.Parameters.AddWithValue("@vat", products.Vat);
                command.Parameters.AddWithValue("@netto_buy_price", products.NettoBuyPrice);
                command.Parameters.AddWithValue("@brutto_buy_price", products.BruttoBuyPrice);
                command.Parameters.AddWithValue("@netto_sell_price", products.NettoSellPrice);
                command.Parameters.AddWithValue("@brutto_sell_price", products.BruttoSellPrice);
                command.Parameters.AddWithValue("@stock", products.Stock);
                command.Parameters.AddWithValue("@min_stock", products.MinStock);
                command.Parameters.AddWithValue("@id", products.Id);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen módosítás!", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void StockReduction(Products products, int stockChanged)
        {
            try
            {
                connection.Open();

                    string querry = "UPDATE products SET stock = @stock Where id = @id;";
                    MySqlCommand command = new MySqlCommand(querry, connection);

                    command.Parameters.AddWithValue("@stock", stockChanged);
                    command.Parameters.AddWithValue("@id", products.Id);
                    command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen módosítás!", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void DeleteProduct(Products product)
        {
            try
            {
                connection.Open();
                string querry1 = "DELETE FROM products WHERE id = @id;";
                MySqlCommand command1 = new MySqlCommand(querry1, connection);
                command1.Parameters.AddWithValue("@id", product.Id);
                command1.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Sikertelen törlés!", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static List<Products> SearchProduct(string kereses)
        {
            try
            {
                connection.Open();
                string querry = $"SELECT * FROM `products` WHERE product_name LIKE '%{kereses}%';";
                MySqlCommand command = new MySqlCommand(querry, connection);
                List<Products> products = new List<Products>();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(new Products((int)reader["id"], (string)reader["product_name"], (string)reader["product_number"], (Quantity)Enum.Parse(typeof(Quantity), reader["quantity"].ToString(), true), (VAT)Enum.Parse(typeof(VAT), reader["vat"].ToString(), true), (double)reader["netto_buy_price"], (double)reader["brutto_buy_price"], (double)reader["netto_sell_price"], (double)reader["brutto_sell_price"], (int)reader["stock"], (int)reader["min_stock"]));
                }
                reader.Close();
                connection.Close();
                return products;
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen listázás", ex);
            }
            finally
            {
                connection.Close();
            }            
        }
        #endregion
        #region DBOrders
        public static List<Orders> ListedOrders()
        {
            try
            {
                connection.Open();
                string querry = "SELECT * FROM orders;";
                string querry2 = "SELECT * FROM order_products WHERE order_id = @order_id;";
                string querry3 = "SELECT * FROM orders_users WHERE order_id = @order_id;";
                string querry4 = "SELECT * FROM orders_company_data WHERE order_id = @order_id;";
                string querry5 = "SELECT * FROM order_partner WHERE order_id = @order_id;";
               
                List<Orders> orders = new List<Orders>();
                List<Orders> orders2 = new List<Orders>();

                List<Products> products = new List<Products>();
                List<Products> products2;
                Users users;
                PartnerClass partner;
                PartnerClass companyData;

                MySqlCommand command = new MySqlCommand(querry, connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    orders.Add(new Orders((int)reader["id"], DateTime.Parse(reader["order_date"].ToString()), DateTime.Parse(reader["completion_date"].ToString()), DateTime.Parse(reader["payment_deadline"].ToString()), (bool)reader["innoviced"], (TermsOfPayment)Enum.Parse(typeof(TermsOfPayment), reader["terms_of_payment"].ToString(), true), (string)reader["customer"]));
                }
                reader.Close();

                for (int i = 0; i < orders.Count; i++)
                {

                    
                    MySqlCommand command2 = new MySqlCommand(querry2, connection);
                    command2.Parameters.AddWithValue("@order_id", orders[i].Id);
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    while (reader2.Read())
                    {
                        products.Add(new Products((int)reader2["id"], (string)reader2["product_name"], (int)reader2["order_id"], (int)reader2["order_discount"], (string)reader2["product_number"], (Quantity)Enum.Parse(typeof(Quantity), reader2["quantity"].ToString(), true), (VAT)Enum.Parse(typeof(VAT), reader2["vat"].ToString(), true), (double)reader2["netto_buy_price"], (double)reader2["brutto_buy_price"], (double)reader2["netto_sell_price"], (double)reader2["brutto_sell_price"], (int)reader2["stock"]));
                    }
                    reader2.Close();

                    MySqlCommand command3 = new MySqlCommand(querry3, connection);
                    command3.Parameters.AddWithValue("@order_id", orders[i].Id);
                    MySqlDataReader reader3 = command3.ExecuteReader();


                    reader3.Read();    
                    users = new Users((int)reader3["id"], (string)reader3["name"], (string)reader3["user_name"], DateTime.Parse(reader3["Registered"].ToString()), (TypeOfUsers)Enum.Parse(typeof(TypeOfUsers), reader3["type_of_users"].ToString(), true), (string)reader3["email"]);
                    reader3.Close();


                    MySqlCommand command4 = new MySqlCommand(querry4, connection);
                    command4.Parameters.AddWithValue("@order_id", orders[i].Id);
                    MySqlDataReader reader4 = command4.ExecuteReader();


                    reader4.Read();    
                    companyData = new PartnerClass((int)reader4["id"], (string)reader4["name"], (string)reader4["tax_number"], (string)reader4["country"], (string)reader4["postcode"], (string)reader4["city"], (string)reader4["address"], (string)reader4["web"], (string)reader4["bank_account"], (string)reader4["comment"]);
                    reader4.Close();

                    MySqlCommand command5 = new MySqlCommand(querry5, connection);
                    command5.Parameters.AddWithValue("@order_id", orders[i].Id);
                    MySqlDataReader reader5 = command5.ExecuteReader();


                    reader5.Read(); 
                    partner = new PartnerClass((int)reader5["id"], (TypeOfPartner)Enum.Parse(typeof(TypeOfPartner), reader5["type"].ToString(), true), (string)reader5["name"], (string)reader5["tax_number"], (string)reader5["billing_country"], (string)reader5["billing_postcode"], (string)reader5["billing_city"], (string)reader5["billing_address"], (string)reader5["delivery_country"], (string)reader5["delivery_postcode"], (string)reader5["delivery_city"], (string)reader5["delivery_address"], (string)reader5["web"], (string)reader5["bank_account"], (string)reader5["comment"]);
                    reader5.Close();
                 
                    orders2.Add(new Orders(orders[i].Id, products2 = new List<Products>(products), users, partner, companyData, orders[i].OrderDate, orders[i].CompletionDate, orders[i].PaymentDeadline, orders[i].Innoviced, orders[i].TermsOfPayment, orders[i].Customer));
                    products.Clear();
                }               
                connection.Close();
                return orders2;
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen listázás", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void UpdateOrdersInnoviceStatus(Orders order)
        {
            try
            {
                connection.Open();
                string querry = "UPDATE orders SET innoviced = @innoviced WHERE id = @id;";
                MySqlCommand command = new MySqlCommand(querry, connection);
                command.Parameters.AddWithValue("@id", order.Id);
                command.Parameters.AddWithValue("@innoviced", order.Innoviced);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Sikertelen számlázás!", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void UpdateOrders(Orders order, List<Products> products, Users user, PartnerClass partner)
        {
            try
            {
                connection.Open();
                string querry = "DELETE FROM order_products WHERE order_id = @order_id;";
                MySqlCommand command = new MySqlCommand(querry, connection);
                command.Parameters.AddWithValue("@order_id", order.Id);
                command.ExecuteNonQuery();


                for (int i = 0; i < products.Count; i++)
                { 
                string querry2 = "INSERT INTO order_products(id, order_id, order_discount, product_name, product_number, quantity, vat, netto_buy_price, brutto_buy_price, netto_sell_price, brutto_sell_price, stock) VALUES (@id, @order_id, @order_discount, @product_name, @product_number, @quantity, @vat, @netto_buy_price, @brutto_buy_price, @netto_sell_price, @brutto_sell_price, @stock);";
                MySqlCommand command2 = new MySqlCommand(querry2, connection);

                    command2.Parameters.AddWithValue("id", products[i].Id);
                    command2.Parameters.AddWithValue("@order_id", order.Id);
                    command2.Parameters.AddWithValue("@order_discount", products[i].OrderDiscount);
                    command2.Parameters.AddWithValue("@product_name", products[i].ProductName);
                    command2.Parameters.AddWithValue("@product_number", products[i].ProductNumber);
                    command2.Parameters.AddWithValue("@quantity", products[i].Quantity);
                    command2.Parameters.AddWithValue("@vat", products[i].Vat);
                    command2.Parameters.AddWithValue("@netto_buy_price", products[i].NettoBuyPrice);
                    command2.Parameters.AddWithValue("@brutto_buy_price", products[i].BruttoBuyPrice);
                    command2.Parameters.AddWithValue("@netto_sell_price", products[i].NettoSellPrice);
                    command2.Parameters.AddWithValue("@brutto_sell_price", products[i].BruttoSellPrice);
                    command2.Parameters.AddWithValue("@stock", products[i].Stock);
                    command2.ExecuteNonQuery();
                }
                string querryOrder = "UPDATE orders SET order_date = @order_date, completion_date = @completion_date, payment_deadline = @payment_deadline, innoviced = @innoviced, terms_of_payment = @terms_of_payment, customer = @customer WHERE id = @id;";
                MySqlCommand commandOrder = new MySqlCommand(querryOrder, connection);

                commandOrder.Parameters.AddWithValue("@order_date", order.OrderDate);
                commandOrder.Parameters.AddWithValue("@completion_date", order.CompletionDate);
                commandOrder.Parameters.AddWithValue("@payment_deadline", order.PaymentDeadline);
                commandOrder.Parameters.AddWithValue("@innoviced", order.Innoviced);
                commandOrder.Parameters.AddWithValue("@terms_of_payment", order.TermsOfPayment);
                commandOrder.Parameters.AddWithValue("@customer", partner.Name);
                commandOrder.Parameters.AddWithValue("@id", order.Id);
                commandOrder.ExecuteNonQuery();

                string querry3 = "UPDATE orders_users SET name = @name, user_name = @user_name, Registered = @Registered, type_of_users = @type_of_users, email = @email WHERE order_id = @order_id;";
                MySqlCommand command3 = new MySqlCommand(querry3, connection);

                command3.Parameters.AddWithValue("@order_id", order.Id);
                command3.Parameters.AddWithValue("@name", user.Name);
                command3.Parameters.AddWithValue("@user_name", user.Username);
                command3.Parameters.AddWithValue("@Registered", user.Registered);
                command3.Parameters.AddWithValue("@type_of_users", user.TypeOfUsers);
                command3.Parameters.AddWithValue("@email", user.Email);
                command3.ExecuteNonQuery();

                string querry4 = "UPDATE order_partner SET type = @type, name = @name, tax_number = @tax_number, billing_country = @billing_country, billing_postcode = @billing_postcode, billing_city = @billing_city, billing_address = @billing_address, delivery_country = @delivery_country, delivery_postcode = @delivery_postcode, delivery_city = @delivery_city, delivery_address = @delivery_address, web = @web, bank_account = @bank_account, comment = @comment WHERE order_id = @order_id;";
                MySqlCommand command4 = new MySqlCommand(querry4, connection);

                command4.Parameters.AddWithValue("@order_id", order.Id);
                command4.Parameters.AddWithValue("@type", partner.Type);
                command4.Parameters.AddWithValue("@name", partner.Name);
                command4.Parameters.AddWithValue("@tax_number", partner.TaxNumber);
                command4.Parameters.AddWithValue("@billing_country", partner.BillingCountry);
                command4.Parameters.AddWithValue("@billing_postcode", partner.BillingPostcode);
                command4.Parameters.AddWithValue("@billing_city", partner.BillingCity);
                command4.Parameters.AddWithValue("@billing_address", partner.BillingAddress);
                command4.Parameters.AddWithValue("@delivery_country", partner.DeliveryCountry);
                command4.Parameters.AddWithValue("@delivery_postcode", partner.DeliveryPostcode);
                command4.Parameters.AddWithValue("@delivery_city", partner.DeiveryCity);
                command4.Parameters.AddWithValue("@delivery_address", partner.DeliveryAddress);
                command4.Parameters.AddWithValue("@web", partner.Web);
                command4.Parameters.AddWithValue("@bank_account", partner.BankAccount);
                command4.Parameters.AddWithValue("@comment", partner.Comment);
                command4.ExecuteNonQuery();
                

                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Sikertelen feltöltés", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void AddNewOrders(Orders order, List<Products> products, Users user, PartnerClass partner, PartnerClass companyData)
        {
            try
            {
                connection.Open();
                string querry = "INSERT INTO orders(order_date, completion_date, payment_deadline, terms_of_payment, customer) VALUES (@order_date, @completion_date, @payment_deadline, @terms_of_payment, @customer);";
                MySqlCommand command = new MySqlCommand(querry, connection);

                command.Parameters.AddWithValue("@order_date", order.OrderDate);
                command.Parameters.AddWithValue("@completion_date", order.CompletionDate);
                command.Parameters.AddWithValue("@payment_deadline", order.PaymentDeadline);
                command.Parameters.AddWithValue("@terms_of_payment", order.TermsOfPayment);
                command.Parameters.AddWithValue("@customer", partner.Name);
                command.ExecuteNonQuery();

                order.Id = (int)command.LastInsertedId;

                for (int i = 0; i < products.Count; i++)
                {
                    string querry2 = "INSERT INTO order_products(id, order_id, order_discount, product_name, product_number, quantity, vat, netto_buy_price, brutto_buy_price, netto_sell_price, brutto_sell_price, stock) VALUES (@id, @order_id, @order_discount, @product_name, @product_number, @quantity, @vat, @netto_buy_price, @brutto_buy_price, @netto_sell_price, @brutto_sell_price, @stock);";
                    MySqlCommand command2 = new MySqlCommand(querry2, connection);

                    command2.Parameters.AddWithValue("@id", products[i].Id);
                    command2.Parameters.AddWithValue("@order_id", order.Id);
                    command2.Parameters.AddWithValue("@order_discount", products[i].OrderDiscount);
                    command2.Parameters.AddWithValue("@product_name", products[i].ProductName);
                    command2.Parameters.AddWithValue("@product_number", products[i].ProductNumber);
                    command2.Parameters.AddWithValue("@quantity", products[i].Quantity);
                    command2.Parameters.AddWithValue("@vat", products[i].Vat);
                    command2.Parameters.AddWithValue("@netto_buy_price", products[i].NettoBuyPrice);
                    command2.Parameters.AddWithValue("@brutto_buy_price", products[i].BruttoBuyPrice);
                    command2.Parameters.AddWithValue("@netto_sell_price", products[i].NettoSellPrice);
                    command2.Parameters.AddWithValue("@brutto_sell_price", products[i].BruttoSellPrice);
                    command2.Parameters.AddWithValue("@stock", products[i].Stock);
                    command2.ExecuteNonQuery();
                }
                string querry3 = "INSERT INTO orders_users(order_id ,name, user_name, Registered, type_of_users, email) VALUES (@order_id, @name, @user_name, @Registered, @type_of_users, @email);";
                MySqlCommand command3 = new MySqlCommand(querry3, connection);

                command3.Parameters.AddWithValue("@order_id", order.Id);
                command3.Parameters.AddWithValue("@name", user.Name);
                command3.Parameters.AddWithValue("@user_name", user.Username);
                command3.Parameters.AddWithValue("@Registered", user.Registered);
                command3.Parameters.AddWithValue("@type_of_users", user.TypeOfUsers);
                command3.Parameters.AddWithValue("@email", user.Email);
                command3.ExecuteNonQuery();

                string querry4 = "INSERT INTO order_partner(order_id, type, name, tax_number, billing_country, billing_postcode, billing_city, billing_address, delivery_country, delivery_postcode, delivery_city, delivery_address, web, bank_account, comment) VALUES (@order_id, @type, @name, @tax_number, @billing_country, @billing_postcode, @billing_city, @billing_address, @delivery_country, @delivery_postcode, @delivery_city, @delivery_address, @web, @bank_account, @comment);";
                MySqlCommand command4 = new MySqlCommand(querry4, connection);

                command4.Parameters.AddWithValue("@order_id", order.Id);
                command4.Parameters.AddWithValue("@type", partner.Type);
                command4.Parameters.AddWithValue("@name", partner.Name);
                command4.Parameters.AddWithValue("@tax_number", partner.TaxNumber);
                command4.Parameters.AddWithValue("@billing_country", partner.BillingCountry);
                command4.Parameters.AddWithValue("@billing_postcode", partner.BillingPostcode);
                command4.Parameters.AddWithValue("@billing_city", partner.BillingCity);
                command4.Parameters.AddWithValue("@billing_address", partner.BillingAddress);
                command4.Parameters.AddWithValue("@delivery_country", partner.DeliveryCountry);
                command4.Parameters.AddWithValue("@delivery_postcode", partner.DeliveryPostcode);
                command4.Parameters.AddWithValue("@delivery_city", partner.DeiveryCity);
                command4.Parameters.AddWithValue("@delivery_address", partner.DeliveryAddress);
                command4.Parameters.AddWithValue("@web", partner.Web);
                command4.Parameters.AddWithValue("@bank_account", partner.BankAccount);
                command4.Parameters.AddWithValue("@comment", partner.Comment);
                command4.ExecuteNonQuery();

                string querry5 = "INSERT INTO orders_company_data(order_id, name, tax_number, country, postcode, city, address, web, bank_account, comment) VALUES (@order_id, @name, @tax_number, @country, @postcode, @city, @address, @web, @bank_account, @comment);";
                MySqlCommand command5 = new MySqlCommand(querry5, connection);

                command5.Parameters.AddWithValue("@order_id", order.Id);
                command5.Parameters.AddWithValue("@name", companyData.Name);
                command5.Parameters.AddWithValue("@tax_number", companyData.TaxNumber);
                command5.Parameters.AddWithValue("@country", companyData.BillingCountry);
                command5.Parameters.AddWithValue("@postcode", companyData.BillingPostcode);
                command5.Parameters.AddWithValue("@city", companyData.BillingCity);
                command5.Parameters.AddWithValue("@address", companyData.BillingAddress);
                command5.Parameters.AddWithValue("@web", companyData.Web);
                command5.Parameters.AddWithValue("@bank_account", companyData.BankAccount);
                command5.Parameters.AddWithValue("@comment", companyData.Comment);
                command5.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Sikertelen feltöltés", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void DetelteOrder(Orders order)
        {
            try
            {
                connection.Open();
                string querry1 = "DELETE FROM orders WHERE id = @id;";
                MySqlCommand command1 = new MySqlCommand(querry1, connection);
                command1.Parameters.AddWithValue("@id", order.Id);
                command1.ExecuteNonQuery();

                string querry2 = "DELETE FROM order_products WHERE order_id = @id;";
                MySqlCommand command2 = new MySqlCommand(querry2, connection);
                command2.Parameters.AddWithValue("@id", order.Id);
                command2.ExecuteNonQuery();

                string querry3 = "DELETE FROM order_partner WHERE order_id = @id;";
                MySqlCommand command3 = new MySqlCommand(querry3, connection);
                command3.Parameters.AddWithValue("@id", order.Id);
                command3.ExecuteNonQuery();

                string querry4 = "DELETE FROM orders_users WHERE order_id = @id;";
                MySqlCommand command4 = new MySqlCommand(querry4, connection);
                command4.Parameters.AddWithValue("@id", order.Id);
                command4.ExecuteNonQuery();

                string querry5 = "DELETE FROM orders_company_data WHERE order_id = @id;";
                MySqlCommand command5 = new MySqlCommand(querry5, connection);
                command5.Parameters.AddWithValue("@id", order.Id);
                command5.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Sikertelen törlés!", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        public static List<Orders> SearchOrders(string kereses)
        {
            try
            {
                connection.Open();
                string querry = $"SELECT * FROM orders WHERE customer LIKE '%{kereses}%';";
                string querry2 = "SELECT * FROM order_products WHERE order_id = @order_id;";
                string querry3 = "SELECT * FROM orders_users WHERE order_id = @order_id;";
                string querry4 = "SELECT * FROM orders_company_data WHERE order_id = @order_id;";
                string querry5 = "SELECT * FROM order_partner WHERE order_id = @order_id;";

                List<Orders> orders = new List<Orders>();
                List<Orders> orders2 = new List<Orders>();

                List<Products> products = new List<Products>();
                List<Products> products2;
                Users users;
                PartnerClass partner;
                PartnerClass companyData;

                MySqlCommand command = new MySqlCommand(querry, connection);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    orders.Add(new Orders((int)reader["id"], DateTime.Parse(reader["order_date"].ToString()), DateTime.Parse(reader["completion_date"].ToString()), DateTime.Parse(reader["payment_deadline"].ToString()), (bool)reader["innoviced"], (TermsOfPayment)Enum.Parse(typeof(TermsOfPayment), reader["terms_of_payment"].ToString(), true), (string)reader["customer"]));
                }
                reader.Close();

                for (int i = 0; i < orders.Count; i++)
                {


                    MySqlCommand command2 = new MySqlCommand(querry2, connection);
                    command2.Parameters.AddWithValue("@order_id", orders[i].Id);
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    while (reader2.Read())
                    {
                        products.Add(new Products((int)reader2["id"], (string)reader2["product_name"], (int)reader2["order_id"], (int)reader2["order_discount"], (string)reader2["product_number"], (Quantity)Enum.Parse(typeof(Quantity), reader2["quantity"].ToString(), true), (VAT)Enum.Parse(typeof(VAT), reader2["vat"].ToString(), true), (double)reader2["netto_buy_price"], (double)reader2["brutto_buy_price"], (double)reader2["netto_sell_price"], (double)reader2["brutto_sell_price"], (int)reader2["stock"]));
                    }
                    reader2.Close();

                    MySqlCommand command3 = new MySqlCommand(querry3, connection);
                    command3.Parameters.AddWithValue("@order_id", orders[i].Id);
                    MySqlDataReader reader3 = command3.ExecuteReader();


                    reader3.Read();
                    users = new Users((int)reader3["id"], (string)reader3["name"], (string)reader3["user_name"], DateTime.Parse(reader3["Registered"].ToString()), (TypeOfUsers)Enum.Parse(typeof(TypeOfUsers), reader3["type_of_users"].ToString(), true), (string)reader3["email"]);
                    reader3.Close();


                    MySqlCommand command4 = new MySqlCommand(querry4, connection);
                    command4.Parameters.AddWithValue("@order_id", orders[i].Id);
                    MySqlDataReader reader4 = command4.ExecuteReader();


                    reader4.Read();
                    companyData = new PartnerClass((int)reader4["id"], (string)reader4["name"], (string)reader4["tax_number"], (string)reader4["country"], (string)reader4["postcode"], (string)reader4["city"], (string)reader4["address"], (string)reader4["web"], (string)reader4["bank_account"], (string)reader4["comment"]);
                    reader4.Close();

                    MySqlCommand command5 = new MySqlCommand(querry5, connection);
                    command5.Parameters.AddWithValue("@order_id", orders[i].Id);
                    MySqlDataReader reader5 = command5.ExecuteReader();


                    reader5.Read();
                    partner = new PartnerClass((int)reader5["id"], (TypeOfPartner)Enum.Parse(typeof(TypeOfPartner), reader5["type"].ToString(), true), (string)reader5["name"], (string)reader5["tax_number"], (string)reader5["billing_country"], (string)reader5["billing_postcode"], (string)reader5["billing_city"], (string)reader5["billing_address"], (string)reader5["delivery_country"], (string)reader5["delivery_postcode"], (string)reader5["delivery_city"], (string)reader5["delivery_address"], (string)reader5["web"], (string)reader5["bank_account"], (string)reader5["comment"]);
                    reader5.Close();

                    orders2.Add(new Orders(orders[i].Id, products2 = new List<Products>(products), users, partner, companyData, orders[i].OrderDate, orders[i].CompletionDate, orders[i].PaymentDeadline, orders[i].Innoviced, orders[i].TermsOfPayment, orders[i].Customer));
                    products.Clear();
                }
                connection.Close();
                return orders2;
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen listázás", ex);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion
    }
}