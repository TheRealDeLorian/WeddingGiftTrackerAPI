--
-- PostgreSQL database dump
--

-- Dumped from database version 12.14
-- Dumped by pg_dump version 15.4 (Debian 15.4-1.pgdg120+1)

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: weddinggifttracker; Type: SCHEMA; Schema: -; Owner: doriancottle_25
--

CREATE SCHEMA weddinggifttracker;


ALTER SCHEMA weddinggifttracker OWNER TO doriancottle_25;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: gift; Type: TABLE; Schema: weddinggifttracker; Owner: doriancottle_25
--

CREATE TABLE weddinggifttracker.gift (
    id integer NOT NULL,
    giftname character varying(100),
    description character varying(1000),
    gifttype integer
);


ALTER TABLE weddinggifttracker.gift OWNER TO doriancottle_25;

--
-- Name: gift_guest; Type: TABLE; Schema: weddinggifttracker; Owner: doriancottle_25
--

CREATE TABLE weddinggifttracker.gift_guest (
    id integer NOT NULL,
    giftid integer,
    guestid integer
);


ALTER TABLE weddinggifttracker.gift_guest OWNER TO doriancottle_25;

--
-- Name: gift_guest_id_seq; Type: SEQUENCE; Schema: weddinggifttracker; Owner: doriancottle_25
--

CREATE SEQUENCE weddinggifttracker.gift_guest_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE weddinggifttracker.gift_guest_id_seq OWNER TO doriancottle_25;

--
-- Name: gift_guest_id_seq; Type: SEQUENCE OWNED BY; Schema: weddinggifttracker; Owner: doriancottle_25
--

ALTER SEQUENCE weddinggifttracker.gift_guest_id_seq OWNED BY weddinggifttracker.gift_guest.id;


--
-- Name: gift_id_seq; Type: SEQUENCE; Schema: weddinggifttracker; Owner: doriancottle_25
--

CREATE SEQUENCE weddinggifttracker.gift_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE weddinggifttracker.gift_id_seq OWNER TO doriancottle_25;

--
-- Name: gift_id_seq; Type: SEQUENCE OWNED BY; Schema: weddinggifttracker; Owner: doriancottle_25
--

ALTER SEQUENCE weddinggifttracker.gift_id_seq OWNED BY weddinggifttracker.gift.id;


--
-- Name: gifttype; Type: TABLE; Schema: weddinggifttracker; Owner: doriancottle_25
--

CREATE TABLE weddinggifttracker.gifttype (
    id integer NOT NULL,
    description character varying(1000)
);


ALTER TABLE weddinggifttracker.gifttype OWNER TO doriancottle_25;

--
-- Name: gifttype_id_seq; Type: SEQUENCE; Schema: weddinggifttracker; Owner: doriancottle_25
--

CREATE SEQUENCE weddinggifttracker.gifttype_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE weddinggifttracker.gifttype_id_seq OWNER TO doriancottle_25;

--
-- Name: gifttype_id_seq; Type: SEQUENCE OWNED BY; Schema: weddinggifttracker; Owner: doriancottle_25
--

ALTER SEQUENCE weddinggifttracker.gifttype_id_seq OWNED BY weddinggifttracker.gifttype.id;


--
-- Name: guest; Type: TABLE; Schema: weddinggifttracker; Owner: doriancottle_25
--

CREATE TABLE weddinggifttracker.guest (
    id integer NOT NULL,
    guestname character varying(1000),
    address character varying(3000)
);


ALTER TABLE weddinggifttracker.guest OWNER TO doriancottle_25;

--
-- Name: guest_id_seq; Type: SEQUENCE; Schema: weddinggifttracker; Owner: doriancottle_25
--

CREATE SEQUENCE weddinggifttracker.guest_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE weddinggifttracker.guest_id_seq OWNER TO doriancottle_25;

--
-- Name: guest_id_seq; Type: SEQUENCE OWNED BY; Schema: weddinggifttracker; Owner: doriancottle_25
--

ALTER SEQUENCE weddinggifttracker.guest_id_seq OWNED BY weddinggifttracker.guest.id;


--
-- Name: summarytext; Type: VIEW; Schema: weddinggifttracker; Owner: doriancottle_25
--

CREATE VIEW weddinggifttracker.summarytext AS
 SELECT gft.giftname,
        CASE
            WHEN ((gft.giftname)::text ~~ '%$50%'::text) THEN 'These people gave 50 bucks'::text
            WHEN ((gft.giftname)::text ~~ '%$200%'::text) THEN 'These people gave 200'::text
            ELSE NULL::text
        END AS "case"
   FROM weddinggifttracker.gift gft;


ALTER TABLE weddinggifttracker.summarytext OWNER TO doriancottle_25;

--
-- Name: gift id; Type: DEFAULT; Schema: weddinggifttracker; Owner: doriancottle_25
--

ALTER TABLE ONLY weddinggifttracker.gift ALTER COLUMN id SET DEFAULT nextval('weddinggifttracker.gift_id_seq'::regclass);


--
-- Name: gift_guest id; Type: DEFAULT; Schema: weddinggifttracker; Owner: doriancottle_25
--

ALTER TABLE ONLY weddinggifttracker.gift_guest ALTER COLUMN id SET DEFAULT nextval('weddinggifttracker.gift_guest_id_seq'::regclass);


--
-- Name: gifttype id; Type: DEFAULT; Schema: weddinggifttracker; Owner: doriancottle_25
--

ALTER TABLE ONLY weddinggifttracker.gifttype ALTER COLUMN id SET DEFAULT nextval('weddinggifttracker.gifttype_id_seq'::regclass);


--
-- Name: guest id; Type: DEFAULT; Schema: weddinggifttracker; Owner: doriancottle_25
--

ALTER TABLE ONLY weddinggifttracker.guest ALTER COLUMN id SET DEFAULT nextval('weddinggifttracker.guest_id_seq'::regclass);


--
-- Data for Name: gift; Type: TABLE DATA; Schema: weddinggifttracker; Owner: doriancottle_25
--

COPY weddinggifttracker.gift (id, giftname, description, gifttype) FROM stdin;
1	Record player	A record player that plays records	7
2	Lamps	A pair of bedside table lamps	4
3	Mixing bowl	a stand up blender and mixing bowl for cooking.	2
13	Dominos gift card	\N	6
14	Walmart gift card	\N	6
15	Cheesecake factory gift card	\N	6
16	Cupbop gift card	\N	6
17	Target gift card ($20)	\N	6
18	Target gift card ($35)	\N	6
19	$80 venmo	\N	1
20	Laundry sorter	\N	7
21	Mixer	\N	2
22	$50 venmo	\N	1
23	$200 venmo	\N	1
24	Pink towels 4 pack	\N	5
25	Drinking glasses	\N	2
26	Duvet cover	\N	3
27	Mattress and bed frame	\N	3
28	Bedsheets	\N	3
29	Blanket	\N	3
30	Silverware	\N	2
\.


--
-- Data for Name: gift_guest; Type: TABLE DATA; Schema: weddinggifttracker; Owner: doriancottle_25
--

COPY weddinggifttracker.gift_guest (id, giftid, guestid) FROM stdin;
1	1	1
2	2	2
3	3	3
21	1	17
22	3	6
23	22	7
24	14	7
25	20	6
26	21	6
27	22	14
28	23	13
29	23	8
30	24	9
31	25	10
32	26	11
33	27	12
34	28	12
35	28	15
36	29	16
37	30	16
\.


--
-- Data for Name: gifttype; Type: TABLE DATA; Schema: weddinggifttracker; Owner: doriancottle_25
--

COPY weddinggifttracker.gifttype (id, description) FROM stdin;
1	Money
2	Kitchen
3	Sleep
4	Decor
6	GiftCard
7	Misc.
5	Toiletry/bath
\.


--
-- Data for Name: guest; Type: TABLE DATA; Schema: weddinggifttracker; Owner: doriancottle_25
--

COPY weddinggifttracker.guest (id, guestname, address) FROM stdin;
1	Pete Davidson	234 dsfdsa street
2	Scrim Sparpashian	5321 gds sdrg
3	tudf fdsfoef	5329 fewofherwf
4	Jim and Karen Serassio	\N
5	Kristen Abboud	\N
6	Cody Cannon	\N
7	Natalie Jacobs	\N
8	Craig Dearing	\N
9	Lisa Hutchison	\N
10	Camila Cortes	\N
11	Mary Tipton	\N
12	Stephen and Cecilia Pistorius	\N
13	Ryan and Kristi Dearing Family	\N
14	Nick and Brooke Adamson	\N
15	Darren and Ruth Bell	\N
16	Matt Arneson Family	\N
17	Lee Ann Dearing	\N
\.


--
-- Name: gift_guest_id_seq; Type: SEQUENCE SET; Schema: weddinggifttracker; Owner: doriancottle_25
--

SELECT pg_catalog.setval('weddinggifttracker.gift_guest_id_seq', 37, true);


--
-- Name: gift_id_seq; Type: SEQUENCE SET; Schema: weddinggifttracker; Owner: doriancottle_25
--

SELECT pg_catalog.setval('weddinggifttracker.gift_id_seq', 30, true);


--
-- Name: gifttype_id_seq; Type: SEQUENCE SET; Schema: weddinggifttracker; Owner: doriancottle_25
--

SELECT pg_catalog.setval('weddinggifttracker.gifttype_id_seq', 7, true);


--
-- Name: guest_id_seq; Type: SEQUENCE SET; Schema: weddinggifttracker; Owner: doriancottle_25
--

SELECT pg_catalog.setval('weddinggifttracker.guest_id_seq', 17, true);


--
-- Name: gift_guest gift_guest_pkey; Type: CONSTRAINT; Schema: weddinggifttracker; Owner: doriancottle_25
--

ALTER TABLE ONLY weddinggifttracker.gift_guest
    ADD CONSTRAINT gift_guest_pkey PRIMARY KEY (id);


--
-- Name: gift gift_pkey; Type: CONSTRAINT; Schema: weddinggifttracker; Owner: doriancottle_25
--

ALTER TABLE ONLY weddinggifttracker.gift
    ADD CONSTRAINT gift_pkey PRIMARY KEY (id);


--
-- Name: gift gift_un; Type: CONSTRAINT; Schema: weddinggifttracker; Owner: doriancottle_25
--

ALTER TABLE ONLY weddinggifttracker.gift
    ADD CONSTRAINT gift_un UNIQUE (giftname);


--
-- Name: gifttype gifttype_pkey; Type: CONSTRAINT; Schema: weddinggifttracker; Owner: doriancottle_25
--

ALTER TABLE ONLY weddinggifttracker.gifttype
    ADD CONSTRAINT gifttype_pkey PRIMARY KEY (id);


--
-- Name: guest guest_pkey; Type: CONSTRAINT; Schema: weddinggifttracker; Owner: doriancottle_25
--

ALTER TABLE ONLY weddinggifttracker.guest
    ADD CONSTRAINT guest_pkey PRIMARY KEY (id);


--
-- Name: gift gift_gifttype_fkey; Type: FK CONSTRAINT; Schema: weddinggifttracker; Owner: doriancottle_25
--

ALTER TABLE ONLY weddinggifttracker.gift
    ADD CONSTRAINT gift_gifttype_fkey FOREIGN KEY (gifttype) REFERENCES weddinggifttracker.gifttype(id);


--
-- Name: gift_guest gift_guest_giftid_fkey; Type: FK CONSTRAINT; Schema: weddinggifttracker; Owner: doriancottle_25
--

ALTER TABLE ONLY weddinggifttracker.gift_guest
    ADD CONSTRAINT gift_guest_giftid_fkey FOREIGN KEY (giftid) REFERENCES weddinggifttracker.gift(id);


--
-- Name: gift_guest gift_guest_guestid_fkey; Type: FK CONSTRAINT; Schema: weddinggifttracker; Owner: doriancottle_25
--

ALTER TABLE ONLY weddinggifttracker.gift_guest
    ADD CONSTRAINT gift_guest_guestid_fkey FOREIGN KEY (guestid) REFERENCES weddinggifttracker.guest(id);


--
-- PostgreSQL database dump complete
--

