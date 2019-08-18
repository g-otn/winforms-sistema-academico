--
-- PostgreSQL database dump
--

-- Dumped from database version 10.5
-- Dumped by pg_dump version 10.5

-- Started on 2019-08-17 20:16:45

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 2 (class 3079 OID 12924)
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- TOC entry 2858 (class 0 OID 0)
-- Dependencies: 2
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


--
-- TOC entry 1 (class 3079 OID 16384)
-- Name: adminpack; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS adminpack WITH SCHEMA pg_catalog;


--
-- TOC entry 2859 (class 0 OID 0)
-- Dependencies: 1
-- Name: EXTENSION adminpack; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION adminpack IS 'administrative functions for PostgreSQL';


SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 197 (class 1259 OID 24848)
-- Name: administradores; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.administradores (
    id integer NOT NULL,
    cargo character varying(80),
    user_id integer
);


ALTER TABLE public.administradores OWNER TO postgres;

--
-- TOC entry 198 (class 1259 OID 24851)
-- Name: administradores_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.administradores_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.administradores_id_seq OWNER TO postgres;

--
-- TOC entry 2860 (class 0 OID 0)
-- Dependencies: 198
-- Name: administradores_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.administradores_id_seq OWNED BY public.administradores.id;


--
-- TOC entry 199 (class 1259 OID 24853)
-- Name: alunos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.alunos (
    id integer NOT NULL,
    ra character varying(18) NOT NULL,
    curso character varying(10),
    datamatricula date,
    user_id integer
);


ALTER TABLE public.alunos OWNER TO postgres;

--
-- TOC entry 200 (class 1259 OID 24856)
-- Name: alunos_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.alunos_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.alunos_id_seq OWNER TO postgres;

--
-- TOC entry 2861 (class 0 OID 0)
-- Dependencies: 200
-- Name: alunos_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.alunos_id_seq OWNED BY public.alunos.id;


--
-- TOC entry 201 (class 1259 OID 24858)
-- Name: cursos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.cursos (
    sigla character varying(10) NOT NULL,
    nome character varying(100)
);


ALTER TABLE public.cursos OWNER TO postgres;

--
-- TOC entry 202 (class 1259 OID 24861)
-- Name: materias; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.materias (
    curso character varying(10) NOT NULL,
    sigla character varying(10) NOT NULL,
    nome character varying(75) NOT NULL,
    lecionador_id integer,
    notas character varying(30)[],
    pesos real[],
    estudantes_id integer[]
);


ALTER TABLE public.materias OWNER TO postgres;

--
-- TOC entry 203 (class 1259 OID 24867)
-- Name: notas; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.notas (
    curso character varying(10) NOT NULL,
    estudante_id integer NOT NULL,
    materia character varying(10) NOT NULL,
    num_nota smallint NOT NULL,
    valor real
);


ALTER TABLE public.notas OWNER TO postgres;

--
-- TOC entry 204 (class 1259 OID 24870)
-- Name: professores; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.professores (
    id integer NOT NULL,
    registro character varying(20) NOT NULL,
    formacao text,
    user_id integer
);


ALTER TABLE public.professores OWNER TO postgres;

--
-- TOC entry 205 (class 1259 OID 24876)
-- Name: professores_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.professores_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.professores_id_seq OWNER TO postgres;

--
-- TOC entry 2862 (class 0 OID 0)
-- Dependencies: 205
-- Name: professores_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.professores_id_seq OWNED BY public.professores.id;


--
-- TOC entry 206 (class 1259 OID 24878)
-- Name: usuarios; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.usuarios (
    id integer NOT NULL,
    login character varying(50) NOT NULL,
    senha character varying(50) NOT NULL,
    rg character varying(14) NOT NULL,
    cpf character varying(14) NOT NULL,
    email character varying(75),
    nome character varying(100) NOT NULL,
    telefone character varying(30),
    tipo character varying(13) NOT NULL
);


ALTER TABLE public.usuarios OWNER TO postgres;

--
-- TOC entry 207 (class 1259 OID 24881)
-- Name: usuarios_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.usuarios_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.usuarios_id_seq OWNER TO postgres;

--
-- TOC entry 2863 (class 0 OID 0)
-- Dependencies: 207
-- Name: usuarios_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.usuarios_id_seq OWNED BY public.usuarios.id;


--
-- TOC entry 2703 (class 2604 OID 24883)
-- Name: administradores id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.administradores ALTER COLUMN id SET DEFAULT nextval('public.administradores_id_seq'::regclass);


--
-- TOC entry 2704 (class 2604 OID 24884)
-- Name: alunos id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.alunos ALTER COLUMN id SET DEFAULT nextval('public.alunos_id_seq'::regclass);


--
-- TOC entry 2705 (class 2604 OID 24885)
-- Name: professores id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.professores ALTER COLUMN id SET DEFAULT nextval('public.professores_id_seq'::regclass);


--
-- TOC entry 2706 (class 2604 OID 24886)
-- Name: usuarios id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuarios ALTER COLUMN id SET DEFAULT nextval('public.usuarios_id_seq'::regclass);


--
-- TOC entry 2708 (class 2606 OID 24888)
-- Name: administradores administradores_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.administradores
    ADD CONSTRAINT administradores_pkey PRIMARY KEY (id);


--
-- TOC entry 2710 (class 2606 OID 24890)
-- Name: alunos alunos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.alunos
    ADD CONSTRAINT alunos_pkey PRIMARY KEY (id);


--
-- TOC entry 2712 (class 2606 OID 24892)
-- Name: cursos cursos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cursos
    ADD CONSTRAINT cursos_pkey PRIMARY KEY (sigla);


--
-- TOC entry 2714 (class 2606 OID 24894)
-- Name: materias materias_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.materias
    ADD CONSTRAINT materias_pkey PRIMARY KEY (curso, sigla);


--
-- TOC entry 2716 (class 2606 OID 24896)
-- Name: notas notas_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.notas
    ADD CONSTRAINT notas_pkey PRIMARY KEY (curso, estudante_id, materia, num_nota);


--
-- TOC entry 2718 (class 2606 OID 24898)
-- Name: professores professores_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.professores
    ADD CONSTRAINT professores_pkey PRIMARY KEY (id);


--
-- TOC entry 2720 (class 2606 OID 24900)
-- Name: usuarios usuarios_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuarios
    ADD CONSTRAINT usuarios_pkey PRIMARY KEY (id);


--
-- TOC entry 2721 (class 2606 OID 24901)
-- Name: administradores administradores_user_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.administradores
    ADD CONSTRAINT administradores_user_id_fkey FOREIGN KEY (user_id) REFERENCES public.usuarios(id);


--
-- TOC entry 2722 (class 2606 OID 24906)
-- Name: alunos alunos_curso_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.alunos
    ADD CONSTRAINT alunos_curso_fkey FOREIGN KEY (curso) REFERENCES public.cursos(sigla);


--
-- TOC entry 2723 (class 2606 OID 24911)
-- Name: alunos alunos_user_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.alunos
    ADD CONSTRAINT alunos_user_id_fkey FOREIGN KEY (user_id) REFERENCES public.usuarios(id);


--
-- TOC entry 2724 (class 2606 OID 24916)
-- Name: materias materias_curso_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.materias
    ADD CONSTRAINT materias_curso_fkey FOREIGN KEY (curso) REFERENCES public.cursos(sigla);


--
-- TOC entry 2725 (class 2606 OID 24921)
-- Name: materias materias_lecionador_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.materias
    ADD CONSTRAINT materias_lecionador_id_fkey FOREIGN KEY (lecionador_id) REFERENCES public.professores(id);


--
-- TOC entry 2726 (class 2606 OID 24926)
-- Name: notas notas_curso_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.notas
    ADD CONSTRAINT notas_curso_fkey FOREIGN KEY (curso) REFERENCES public.cursos(sigla);


--
-- TOC entry 2727 (class 2606 OID 24931)
-- Name: notas notas_estudante_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.notas
    ADD CONSTRAINT notas_estudante_id_fkey FOREIGN KEY (estudante_id) REFERENCES public.alunos(id);


--
-- TOC entry 2728 (class 2606 OID 24936)
-- Name: professores professores_user_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.professores
    ADD CONSTRAINT professores_user_id_fkey FOREIGN KEY (user_id) REFERENCES public.usuarios(id);


-- Completed on 2019-08-17 20:16:45

--
-- PostgreSQL database dump complete
--