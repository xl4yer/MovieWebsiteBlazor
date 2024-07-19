using Mov.Class;
using Mov.Models;
using System.Data;
using MySql.Data.MySqlClient;

namespace Mov.Services
{
    public class MovServices
    {
        private readonly AppDb _constring;
        public IConfiguration Configuration;

        public MovServices(AppDb constring, IConfiguration configuration)
        {
            _constring = constring;
            Configuration = configuration;
        }

        public async Task<List<mov>> Movies()
        {
            List<mov> mov = new List<mov>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("Movies", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    var rdr = await com.ExecuteReaderAsync().ConfigureAwait(false);
                    while (await rdr.ReadAsync().ConfigureAwait(false))
                    {
                        mov.Add(new mov
                        {
                            movID = rdr["movID"].ToString(),
                            photo = (byte[])rdr["photo"],
                            title = rdr["title"].ToString(),
                            genre = rdr["genre"].ToString(),
                            description = rdr["description"].ToString(),
                            url = rdr["url"].ToString(),
                        });
                    }
                    await rdr.CloseAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    // Handle the exception here
                }
                finally
                {
                    await con.CloseAsync().ConfigureAwait(false);
                }
            }
            return mov;
        }

        public async Task<List<mov>> Search(string search)
        {
            List<mov> mov = new List<mov>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("Search", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("search", search);
                    com.Parameters.AddWithValue("@searchWildcard", $"{search}%");
                    var rdr = await com.ExecuteReaderAsync().ConfigureAwait(false);
                    while (await rdr.ReadAsync().ConfigureAwait(false))
                    {
                        mov.Add(new mov
                        {
                            movID = rdr["movID"].ToString(),
                            photo = (byte[])rdr["photo"],
                            title = rdr["title"].ToString(),
                            genre = rdr["genre"].ToString(),
                            description = rdr["description"].ToString(),
                            url = rdr["url"].ToString(),
                        });
                    }
                    await rdr.CloseAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    // Handle the exception here
                }
                finally
                {
                    await con.CloseAsync().ConfigureAwait(false);
                }
            }
            return mov;
        }

        public async Task<List<mov>> Action()
        {
            List<mov> mov = new List<mov>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("Action", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    var rdr = await com.ExecuteReaderAsync().ConfigureAwait(false);
                    while (await rdr.ReadAsync().ConfigureAwait(false))
                    {
                        mov.Add(new mov
                        {
                            movID = rdr["movID"].ToString(),
                            photo = (byte[])rdr["photo"],
                            title = rdr["title"].ToString(),
                            genre = rdr["genre"].ToString(),
                            description = rdr["description"].ToString(),
                            url = rdr["url"].ToString(),
                        });
                    }
                    await rdr.CloseAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    // Handle the exception here
                }
                finally
                {
                    await con.CloseAsync().ConfigureAwait(false);
                }
            }
            return mov;
        }

        public async Task<List<mov>> Adventure()
        {
            List<mov> mov = new List<mov>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("Adventure", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    var rdr = await com.ExecuteReaderAsync().ConfigureAwait(false);
                    while (await rdr.ReadAsync().ConfigureAwait(false))
                    {
                        mov.Add(new mov
                        {
                            movID = rdr["movID"].ToString(),
                            photo = (byte[])rdr["photo"],
                            title = rdr["title"].ToString(),
                            genre = rdr["genre"].ToString(),
                            description = rdr["description"].ToString(),
                            url = rdr["url"].ToString(),
                        });
                    }
                    await rdr.CloseAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    // Handle the exception here
                }
                finally
                {
                    await con.CloseAsync().ConfigureAwait(false);
                }
            }
            return mov;
        }

        public async Task<List<mov>> Animation()
        {
            List<mov> mov = new List<mov>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("Animation", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    var rdr = await com.ExecuteReaderAsync().ConfigureAwait(false);
                    while (await rdr.ReadAsync().ConfigureAwait(false))
                    {
                        mov.Add(new mov
                        {
                            movID = rdr["movID"].ToString(),
                            photo = (byte[])rdr["photo"],
                            title = rdr["title"].ToString(),
                            genre = rdr["genre"].ToString(),
                            description = rdr["description"].ToString(),
                            url = rdr["url"].ToString(),
                        });
                    }
                    await rdr.CloseAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    // Handle the exception here
                }
                finally
                {
                    await con.CloseAsync().ConfigureAwait(false);
                }
            }
            return mov;
        }

        public async Task<List<mov>> Comedy()
        {
            List<mov> mov = new List<mov>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("Comedy", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    var rdr = await com.ExecuteReaderAsync().ConfigureAwait(false);
                    while (await rdr.ReadAsync().ConfigureAwait(false))
                    {
                        mov.Add(new mov
                        {
                            movID = rdr["movID"].ToString(),
                            photo = (byte[])rdr["photo"],
                            title = rdr["title"].ToString(),
                            genre = rdr["genre"].ToString(),
                            description = rdr["description"].ToString(),
                            url = rdr["url"].ToString(),
                        });
                    }
                    await rdr.CloseAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    // Handle the exception here
                }
                finally
                {
                    await con.CloseAsync().ConfigureAwait(false);
                }
            }
            return mov;
        }

        public async Task<List<mov>> Crime()
        {
            List<mov> mov = new List<mov>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("Crime", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    var rdr = await com.ExecuteReaderAsync().ConfigureAwait(false);
                    while (await rdr.ReadAsync().ConfigureAwait(false))
                    {
                        mov.Add(new mov
                        {
                            movID = rdr["movID"].ToString(),
                            photo = (byte[])rdr["photo"],
                            title = rdr["title"].ToString(),
                            genre = rdr["genre"].ToString(),
                            description = rdr["description"].ToString(),
                            url = rdr["url"].ToString(),
                        });
                    }
                    await rdr.CloseAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    // Handle the exception here
                }
                finally
                {
                    await con.CloseAsync().ConfigureAwait(false);
                }
            }
            return mov;
        }

        public async Task<List<mov>> Documentary()
        {
            List<mov> mov = new List<mov>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("Documentary", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    var rdr = await com.ExecuteReaderAsync().ConfigureAwait(false);
                    while (await rdr.ReadAsync().ConfigureAwait(false))
                    {
                        mov.Add(new mov
                        {
                            movID = rdr["movID"].ToString(),
                            photo = (byte[])rdr["photo"],
                            title = rdr["title"].ToString(),
                            genre = rdr["genre"].ToString(),
                            description = rdr["description"].ToString(),
                            url = rdr["url"].ToString(),
                        });
                    }
                    await rdr.CloseAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    // Handle the exception here
                }
                finally
                {
                    await con.CloseAsync().ConfigureAwait(false);
                }
            }
            return mov;
        }

        public async Task<List<mov>> Drama()
        {
            List<mov> mov = new List<mov>();
            using (var con = new MySqlConnection(_constring.GetConnection()))
            {
                try
                {
                    await con.OpenAsync().ConfigureAwait(false);
                    var com = new MySqlCommand("Drama", con)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    var rdr = await com.ExecuteReaderAsync().ConfigureAwait(false);
                    while (await rdr.ReadAsync().ConfigureAwait(false))
                    {
                        mov.Add(new mov
                        {
                            movID = rdr["movID"].ToString(),
                            photo = (byte[])rdr["photo"],
                            title = rdr["title"].ToString(),
                            genre = rdr["genre"].ToString(),
                            description = rdr["description"].ToString(),
                            url = rdr["url"].ToString(),
                        });
                    }
                    await rdr.CloseAsync().ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    // Handle the exception here
                }
                finally
                {
                    await con.CloseAsync().ConfigureAwait(false);
                }
            }
            return mov;
        }

    }
}
