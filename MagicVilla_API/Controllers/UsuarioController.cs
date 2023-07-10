﻿using MagicVilla_API.Modelos;
using MagicVilla_API.Modelos.Dto;
using MagicVilla_API.Repositorio.IRepositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MagicVilla_API.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersionNeutral]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepo;
        private APIResponse _response;

        public UsuarioController(IUsuarioRepositorio usuarioRepo)
        {
            _usuarioRepo = usuarioRepo;
            _response = new();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto modelo)
        {
            var loginResponse = await _usuarioRepo.Login(modelo);
            if (loginResponse.Usuario == null || string.IsNullOrEmpty(loginResponse.Token))
            {
                _response.statusCode = HttpStatusCode.BadRequest;
                _response.IsExitoso = false;
                _response.ErrorMensages.Add("UserName o Password son Incorrectos");
                return BadRequest(_response);
            }

            _response.IsExitoso = true;
            _response.statusCode = HttpStatusCode.OK;
            _response.Resultado = loginResponse;
            return Ok(_response);
        }

        [HttpPost("registrar")]
        public async Task<IActionResult> Registrar([FromBody] RegistroRequestDto modelo)
        {
            bool isUsuarioUnico = _usuarioRepo.IsUsuarioUnico(modelo.UserName);

            if (!isUsuarioUnico)
            {
                _response.statusCode = HttpStatusCode.BadRequest;
                _response.IsExitoso = false;
                _response.ErrorMensages.Add("El Usuario ya Existe");
                return BadRequest(_response);
            }
            var usuario = await _usuarioRepo.Registrar(modelo);
            if (usuario == null)
            {
                _response.statusCode = HttpStatusCode.BadRequest;
                _response.IsExitoso = false;
                _response.ErrorMensages.Add("Error al Registrar Usuario");
                return BadRequest(_response);
            }
            _response.IsExitoso = true;
            _response.statusCode = HttpStatusCode.OK;

            return Ok(_response);
        }
    }
}
